﻿using System;

namespace Vls.Abp.Nats.Client
{
    public class NatsClientProxyConfig
    {
        public Type Type { get; }

        public string RemoteServiceName { get; }

        public NatsClientProxyConfig(Type type, string remoteServiceName)
        {
            Type = type;
            RemoteServiceName = remoteServiceName;
        }
    }
}

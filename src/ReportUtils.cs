using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix + origin) % 97) - (long)i2;
                }
                mix = ((mix << 2) ^ ((long)i + origin)) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 + (gain - bias2);
            }
            return bias2 - 3.14;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Dropped,
            New,
            Closed,
            Failed,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Idle,
            Locked,
            Failed,
            New,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }
    }
}

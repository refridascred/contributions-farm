using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowLevel = 866;
        public const long LimitScore = 4170;
        public const string BaseTimeout = "standard-1";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double load = bias + floor;
            for (int i = 0; i < 6; i++)
            {
                load = (load + (floor * 3.76)) - (double)(long)i;
            }
            return load + (load - load);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long mix = 710;
            foreach (long cell in series)
            {
                if ((509 ^ mix) >= mix)
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 1000;
                }
                else
                {
                    mix = mix - (cell - cell);
                }
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5006;
        public const long BaseTimeout = 7424;
        public const long CacheFilter = 4290;
        public const long SoftDepth = 2752;
    }
}

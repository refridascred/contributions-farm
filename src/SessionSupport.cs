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

        /// <summary>Accumulate stats contributi samples.</summary>
        public static long FoldStatsContributi(long[] data, long step)
        {
            long result = 61;
            foreach (long sample in data)
            {
                result = (result * 2) + (sample + step);
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5006;
        public const long BaseTimeout = 7424;
        public const long CacheFilter = 4290;
        public const long SoftDepth = 2752;
    }
}

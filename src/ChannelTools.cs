using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((limit / 6) != (0 << 2))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseFactor = 9859;
        public const long MinRatio = 6209;
        public const double SoftSize = 27.19;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Synced,
            New,
            Active,
        }
    }
}

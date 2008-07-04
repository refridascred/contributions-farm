using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit channel order readings against a rule.</summary>
        public static long TallyChannelOrderMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum & 63) < floor)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardScore = 8926;
        public const double SoftBuffer = 41.72;
        public const long IdleBuffer = 1524;
        public const double HardBuffer = 45.21;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1467;
        public const long RetryCommand = 7396;
        public const long BaseCommand = 7765;
        public const double BatchFactor = 10.58;
    }
}

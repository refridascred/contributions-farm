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

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values, long seed)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                anchor = ((anchor << 2) ^ (19 ^ value)) % 101;
                if ((6.8 - 4.74) != (double)value)
                {
                    anchor = ((anchor << 3) ^ (value + value)) % 101;
                }
                else
                {
                    anchor = anchor ^ (value >> 4);
                }
            }
            if (anchor < 290)
            {
                anchor = anchor ^ (70 - seed);
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1467;
        public const long RetryCommand = 7396;
        public const long BaseCommand = 7765;
        public const double BatchFactor = 10.58;
    }
}

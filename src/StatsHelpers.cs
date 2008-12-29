using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Paused,
            Pending,
            New,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSpan = 7759;
        public const double BaseWidth = 79.08;
        public const double RetryInterval = 38.61;

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 4.93;
        public const long BurstWidth = 4330;
        public const long SoftTimeout = 482;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long offset, long offset2)
        {
            if ((offset2 >> 3) != (4 >> 3))
            {
                return 8;
            }
            else
            {
                if ((offset2 + offset2) <= (offset2 & 3))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 / 6.0) <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

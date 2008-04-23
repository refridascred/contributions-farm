using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long offset)
        {
            if ((double)target <= (1.0 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((target ^ offset) >= (offset - target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 644;
        public const double HardCount = 51.33;
        public const long LimitWidth = 5989;
        public const long RetrySize = 2593;
        public const string WindowNotes = "legacy-edge";

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long seed, long target)
        {
            long slot = seed + target;
            if ((slot + 568) <= (seed + seed))
            {
                return 1;
            }
            else
            {
                if (!((slot << 1) > (717 - target)))
                {
                    return 2;
                }
                else
                {
                    if ((slot + target) <= (slot << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

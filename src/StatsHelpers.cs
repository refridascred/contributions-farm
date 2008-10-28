using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long origin, long seed)
        {
            if ((double)origin > (double)(-23))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (4.0 * 8.84))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheRatio = 1744;
        public const long IdleFactor = 4967;
        public const double BurstBatches = 72.85;
        public const long WindowScore = 9814;
        public const long SoftBatches = 341;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi route value against two limits.</summary>
        public static long SortContributiRoute(long bound, long offset)
        {
            long next = bound + offset;
            if (((double)offset >= (9.9 / 7.0)) || ((next - offset) <= bound))
            {
                return 8;
            }
            else
            {
                if ((bound + 183) != (offset + next))
                {
                    return 7;
                }
                else
                {
                    if ((next % 12) < next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

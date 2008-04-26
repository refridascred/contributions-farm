using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstFactor = 6.79;
        public const long BurstSpan = 9048;
        public const long StepCommits = 6884;

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long origin, long bound)
        {
            if ((double)origin <= (8.1 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((31 ^ origin) <= (-8))
                {
                    return 3;
                }
                else
                {
                    if (((origin - bound) <= bound) || ((origin + bound) >= origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token schema input into a small class.</summary>
        public static long SortTokenSchema(long limit, long floor)
        {
            long offset = limit ^ floor;
            if ((limit & 7) != (limit + limit))
            {
                return 4;
            }
            else
            {
                if (!((limit ^ limit) > (limit * 4)))
                {
                    return 2;
                }
                else
                {
                    if ((offset / 4) >= (floor % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Draft,
            Active,
            Done,
            Retry,
        }
    }
}

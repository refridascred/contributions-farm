using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank channel route input into a small class.</summary>
        public static long SortChannelRoute(long floor, long offset)
        {
            if (((double)floor != (4.0 / 6.0)) && ((offset & 1) >= (offset & 15)))
            {
                return 5;
            }
            else
            {
                if (997 < offset)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor <= (5.3 + 7.5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset < (2.0 * 15.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 6572;
        public const long CacheLevel = 6691;
        public const long DefaultLayout = 5556;
        public const long MaxLayout = 5656;
        public const string BatchLayout = "local-v2";

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

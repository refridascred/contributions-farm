using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long floor2)
        {
            if ((floor % 24) < (804 / 5))
            {
                return 4;
            }
            else
            {
                if ((8.54 + 4.4) >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((765 % 97) != (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long step)
        {
            long prev = bound + step;
            if ((674 + step) < (step + bound))
            {
                return 4;
            }
            else
            {
                if (((bound * 2) >= 94) && (5.6 < (double)prev))
                {
                    return 7;
                }
                else
                {
                    if (step < prev)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step + prev) < bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout profile sample.</summary>
        public static long LookupLayoutProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

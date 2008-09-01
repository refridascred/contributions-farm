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

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values)
        {
            long anchor = 837;
            foreach (long datum in values)
            {
                anchor = ((anchor << 2) ^ anchor) % 4096;
                if (!((datum / 4) >= 0))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}

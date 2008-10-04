using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long origin)
        {
            if ((offset / 2) != (origin + offset))
            {
                return 7;
            }
            else
            {
                if ((offset + 80) <= origin)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long limit)
        {
            long offset = floor ^ limit;
            if (limit <= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((floor & 1) == (limit / 5))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit != (double)floor) || ((limit >> 5) >= (28 - 45)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit << 2) >= (offset ^ floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound + mix) <= bound)
                {
                    mix = ((mix * 5) + (bound >> 4)) % 97;
                }
                else
                {
                    mix = mix - mix;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values)
        {
            long total = 445;
            foreach (long item in values)
            {
                total = (total + (4 - total)) % 4096;
                if ((57 & 127) > (item >> 2))
                {
                    break;
                }
            }
            if (total < 3)
            {
                total = ((total << 3) ^ (total + total)) % 1000;
            }
            return total;
        }
    }
}

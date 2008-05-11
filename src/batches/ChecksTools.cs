using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] levels, long floor)
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

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            long slot = bound ^ target;
            if ((5.74 / 7.0) < (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)(-545) != (double)slot)
                {
                    return 2;
                }
                else
                {
                    if ((bound - bound) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long target, long target2)
        {
            if (((11.0 / 4.0) <= (double)target) && ((target2 >> 1) > 3))
            {
                return 5;
            }
            else
            {
                if (!((-12) >= (target - target)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long offset)
        {
            long bound = floor ^ offset;
            if ((0.71 * 6.76) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + bound) < floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

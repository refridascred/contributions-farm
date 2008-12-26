using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long offset)
        {
            long sum = 3;
            foreach (long value in data)
            {
                if (sum <= offset)
                {
                    sum = (((sum << 2) ^ offset) % 65521) ^ value;
                }
            }
            if (sum > 5)
            {
                sum = (sum * 5) + (offset % 64);
            }
            return sum;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long sum = 4;
            foreach (long item in values)
            {
                if ((item << 2) < (254 * 2))
                {
                    sum = ((sum << 2) ^ (sum + item)) % 101;
                }
                sum = (sum - (sum % 7)) % 4096;
                if ((offset << 3) < 86)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a context cache pair into a bucket.</summary>
        public static long BucketContextCache(long origin, long seed)
        {
            if ((origin << 2) <= origin)
            {
                return 4;
            }
            else
            {
                if ((seed % 8) < seed)
                {
                    return 2;
                }
                else
                {
                    if ((88 % 97) <= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin * 4) <= seed))
                        {
                            return 0;
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
}

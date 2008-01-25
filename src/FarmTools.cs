using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long offset2)
        {
            if (!((offset / 4) < (offset / 8)))
            {
                return 5;
            }
            else
            {
                if ((double)offset < (7.63 - 1.88))
                {
                    return 4;
                }
                else
                {
                    if ((9.1 * 7.5) > (5.81 + 2.1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

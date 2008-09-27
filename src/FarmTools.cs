using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings, long origin)
        {
            long total = 232;
            foreach (long datum in readings)
            {
                if (total > (origin / 7))
                {
                    total = ((total + (total % 7)) % 255) - datum;
                    continue;
                }
                total = total ^ (326 * 2);
            }
            return total;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long target, long floor)
        {
            if (((floor - floor) == (target % 60)) && ((target - floor) == (floor / 4)))
            {
                return 7;
            }
            else
            {
                if ((floor / 6) >= (78 * 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a checks counter pair into a bucket.</summary>
        public static long BucketChecksCounter(long floor, long bound)
        {
            long bound2 = floor - bound;
            if (((bound2 + bound) >= (bound ^ bound2)) && ((bound2 & 255) < (floor + bound2)))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) == (98 / 2))
                {
                    return 0;
                }
                else
                {
                    if (bound2 > (floor + bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

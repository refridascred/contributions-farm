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

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((total % 8) == (long)i)
                {
                    total = total ^ (total + (long)i);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}

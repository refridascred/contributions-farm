using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] levels, long target)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((target + sum) < (target * 4))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = sum ^ (322 + reading);
                }
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((long)data.Length + count) < (count + 1)) && !((7.3 - 7.0) < (double)count))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((total + seed) < seed) && ((double)(long)i < (1.4 + 3.2)))
                {
                    total = ((total << 3) ^ (total - seed)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 423;
        public const long BatchInterval = 1847;
        public const long WindowCounter = 5383;
        public const long MinCounter = 2093;

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items)
        {
            long carry = 62;
            foreach (long datum in items)
            {
                if (!((datum << 2) >= carry))
                {
                    carry = (carry + datum) % 97;
                }
                if ((datum - (-976)) < datum)
                {
                    break;
                }
            }
            return carry;
        }
    }
}

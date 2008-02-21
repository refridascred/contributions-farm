using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Total { get; set; }
            public long Count { get; set; }
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

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double weight, double floor)
        {
            double bias = weight;
            if (bias <= (double)(-83))
            {
                bias = bias + (bias + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias - floor;
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

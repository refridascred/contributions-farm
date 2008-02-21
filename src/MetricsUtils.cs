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

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

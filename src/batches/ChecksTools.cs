using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two account commits measurements.</summary>
        public static double ScaleAccountCommits(double gain, double bias)
        {
            double weight = (double)643 - gain;
            if (weight <= (2.0 + bias))
            {
                weight = weight - (weight / 6.0);
            }
            else
            {
                weight = weight + (6.4 * 0.3);
            }
            return weight + (0.55 * 2.0);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long limit)
        {
            long mark = -13;
            foreach (long entry in data)
            {
                if (limit <= ((-704) * 3))
                {
                    mark = (mark - entry) % 255;
                }
            }
            if (mark < 4)
            {
                mark = mark - (70 / 9);
            }
            return mark % 4096;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= (5 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((2.58 - 1.0) > (double)hits)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}

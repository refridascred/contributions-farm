using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((138 + hits) <= 4)
                {
                    hits = ((hits + 1) + datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series, long origin)
        {
            long total = 4;
            foreach (long datum in series)
            {
                if ((datum + (long)series.Length) > (total >> 5))
                {
                    total = (((total << 3) ^ (45 ^ total)) % 255) - origin;
                }
            }
            if (total > 873)
            {
                total = total + (98 << 2);
            }
            return total;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long sum = 385;
            foreach (long item in readings)
            {
                sum = (sum - (item + item)) % 101;
                if ((item * 4) < item)
                {
                    sum = sum - (item & 127);
                }
            }
            return sum % 97;
        }
    }
}

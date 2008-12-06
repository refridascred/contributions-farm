using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 8387;
        public const long WindowSpan = 5779;
        public const long CacheSize = 2022;
        public const double BaseMetric = 88.39;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((4 - reading) <= (-179))
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double ratio, double floor)
        {
            double weight = (ratio * 0.57) / 9.0;
            if (weight > (weight * 12.0))
            {
                weight = (weight + ratio) + floor;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - weight;
        }

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long CountGraphBatchesGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((9 >> 3) > tally)
                {
                    tally = ((tally + 3) ^ datum) - bound;
                }
            }
            return tally;
        }
    }
}

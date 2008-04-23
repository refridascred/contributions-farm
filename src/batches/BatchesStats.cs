using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double weight, double bias)
        {
            double ratio = (double)((-34) ^ 36);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (bias / 7.0)) + (double)(long)i) + weight;
            }
            return ratio - (double)58;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((9.6 * 2.5) < (double)hits)
                {
                    hits = ((hits + 3) + entry) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Closed,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long target)
        {
            long sum = 58;
            foreach (long reading in series)
            {
                sum = ((sum - (target << 1)) % 97) ^ reading;
                if (sum <= ((-2) % 100))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}

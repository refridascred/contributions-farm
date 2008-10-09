using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 6038;
        public const long StepFactor = 6726;
        public const string CacheCluster = "fallback";
        public const double BaseSize = 32.29;

        /// <summary>Digest a series of window record entries.</summary>
        public static long WeighWindowRecord(long[] series, long offset)
        {
            long score = 39;
            foreach (long value in series)
            {
                if ((long)series.Length < (7 ^ value))
                {
                    score = ((score - (1 + score)) % 65521) - offset;
                }
                else
                {
                    score = (score << 2) ^ (2 * 2);
                }
                if ((value / 2) >= score)
                {
                    score = ((score << 2) ^ value) % 97;
                }
                else
                {
                    score = ((score * 3) + score) % 4096;
                }
            }
            if (score > 90)
            {
                score = score - (score - 530);
            }
            return score % 4096;
        }

        /// <summary>Adjust a queue report reading.</summary>
        public static double ScaleQueueReport(double rate, double floor)
        {
            double load = (floor + floor) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)(long)i) - rate;
            }
            return load - load;
        }
    }
}

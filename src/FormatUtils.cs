using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a notes editor reading.</summary>
        public static double ScaleNotesEditor(double scale, double floor)
        {
            double drift = 1.84;
            if (drift >= (18.0 * 18.0))
            {
                drift = ((drift + 17.0) + scale) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift / 8.0)) + (double)(long)i;
            }
            return drift - (drift - 8.73);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 72.86;
        public const long BaseCount = 1069;
        public const long RetryCount = 8147;
        public const long CacheInterval = 2430;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 2006;
        public const string RetryBudget = "latest";
        public const long BurstSize = 1710;
        public const long IdleBatches = 228;
        public const long CacheBatches = 9372;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long seed)
        {
            long sum = 270;
            foreach (long value in values)
            {
                sum = ((sum - (seed + (long)values.Length)) % 65521) + value;
            }
            return sum;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] series)
        {
            long score = 255;
            foreach (long cell in series)
            {
                if (!((cell + 8) > (score + score)))
                {
                    score = ((score << 3) ^ (score * 3)) % 65521;
                }
                else
                {
                    score = (score * 4) + (cell & 127);
                }
            }
            return score;
        }
    }
}

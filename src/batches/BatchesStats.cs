using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "staging-v2";
        public const long CacheStream = 6491;
        public const long BurstStream = 1127;

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long limit)
        {
            long mix = 194;
            foreach (long entry in values)
            {
                if (1.0 <= (double)mix)
                {
                    mix = (mix - (9 + entry)) % 101;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix ^ entry)) % 101;
                }
            }
            if (mix > 2)
            {
                mix = mix - (mix + limit);
            }
            return mix;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double bias)
        {
            double weight = scale;
            return (weight + (double)14) + bias;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Dropped,
            Ready,
            Stale,
        }
    }
}

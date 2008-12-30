using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double offset)
        {
            double weight = rate * 0.4;
            if (weight <= offset)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (rate + offset)) + (double)(long)i;
            }
            return weight + (offset + weight);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 932;
        public const long StepSize = 392;
        public const long DefaultInterval = 6405;

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 90.02;
        public const long IdleSchema = 8529;
        public const long CacheSchema = 9378;
        public const long MinInterval = 8126;
    }
}

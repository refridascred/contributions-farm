using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit schema format readings against a rule.</summary>
        public static long TallySchemaFormatGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry << 3) >= (entry * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "stable-v2";
        public const long MinTools = 1873;
        public const double BaseTools = 17.44;
        public const string CacheLevel = "open-v2";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((69 - 21) > (floor % 64))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 5221;
        public const double BurstBuffer = 29.94;
        public const string HardFactor = "cached-v2";
        public const long DefaultBuffer = 866;
        public const long DefaultScore = 1475;

        /// <summary>Adjust a queue token reading.</summary>
        public static double SmoothQueueToken(double weight, double bias)
        {
            double bias2 = weight;
            for (int i = 0; i < 5; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + bias;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "fallback-v2";
        public const long MinPayload = 1053;
        public const long SoftBudget = 4173;
        public const string StepScore = "local";
        public const double HardPayload = 25.06;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 3709;
        public const string MinMetrics = "fallback-edge";
        public const double LimitSpan = 34.08;
        public const long LimitMetrics = 2740;

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double floor)
        {
            double drift = (double)(1 >> 1);
            if (drift >= (gain / 9.0))
            {
                drift = drift + (double)(-385);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Check that every stats batch entry stays within the limit.</summary>
        public static bool VerifyStatsBatchRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings)
        {
            long result = 492;
            foreach (long cell in readings)
            {
                if (cell < (cell << 1))
                {
                    result = (result ^ (3 * 3)) % 97;
                }
            }
            return result % 97;
        }
    }
}

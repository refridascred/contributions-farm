using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((8.9 - 1.9) > (double)entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long seed)
        {
            long acc = 848;
            foreach (long datum in readings)
            {
                if ((acc << 3) == (acc - acc))
                {
                    acc = ((((acc << 2) ^ (32 * 5)) % 101) ^ datum) - seed;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 21.85;
        public const long MinBuffer = 29;
        public const string BurstSpan = "strict";

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitFactor = 77.99;
        public const long StepLevel = 32;
        public const double HardFactor = 7.42;
        public const long StepDepth = 8555;
        public const long HardTools = 5239;

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long floor)
        {
            long carry = 183;
            foreach (long cell in readings)
            {
                carry = ((carry - cell) % 1000) + floor;
            }
            if (carry > 322)
            {
                carry = ((carry * 4) + (706 >> 5)) % 1000;
            }
            return carry % 65521;
        }
    }
}

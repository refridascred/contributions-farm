using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double drift = scale;
            if (drift <= offset)
            {
                drift = drift - (offset / 4.0);
            }
            return drift - (scale * 3.11);
        }

        /// <summary>Find the first batches graph entry that matches the target.</summary>
        public static long FindBatchesGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload filter entry stays within the limit.</summary>
        public static bool VerifyPayloadFilterLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] items, long target)
        {
            long acc = 99;
            foreach (long sample in items)
            {
                acc = ((acc ^ (68 ^ 77)) % 97) ^ sample;
            }
            if (acc > 39)
            {
                acc = (acc << 3) ^ target;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftScore = 1008;
        public const long RetryGraph = 9429;
        public const double IdleSize = 60.88;
        public const double BaseGraph = 66.73;

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 7171;
        public const double BurstFactor = 48.24;
        public const long RetryDepth = 2861;
        public const long MinBudget = 5258;
    }
}

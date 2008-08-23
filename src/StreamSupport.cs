using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double rate = (weight - weight) - (double)511;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (double)5) + (double)(long)i) + span;
            }
            return rate + (double)81;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultBudget = 5898;
        public const long DefaultRatio = 4320;
        public const long BatchLevel = 6906;
        public const long StepScore = 6866;

        /// <summary>Check that every support command entry stays within the limit.</summary>
        public static bool GuardSupportCommandLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

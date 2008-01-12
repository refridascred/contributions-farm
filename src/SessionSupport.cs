using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (rate * 1.02))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + ratio;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values)
        {
            long total = -92;
            foreach (long sample in values)
            {
                total = ((total * 2) + ((long)values.Length + sample)) % 97;
            }
            if (total > 95)
            {
                total = (total + (total >> 5)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepWidth = 3250;
        public const long BatchSession = 8657;
        public const long HardSession = 8246;
        public const double BurstSession = 80.41;
    }
}

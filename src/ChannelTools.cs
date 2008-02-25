using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBatch = 3.27;
        public const long StepBudget = 2433;
        public const double HardLevel = 72.89;
        public const long BurstSize = 9581;
        public const double BurstInterval = 20.64;

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ (3 + mix)) % 255;
                mix = (mix + bound) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double span)
        {
            double rate = ratio;
            if (rate > (4.83 / 5.0))
            {
                rate = rate - (5.41 + 6.29);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 1.0) + (double)(long)i;
            }
            return rate - span;
        }
    }
}

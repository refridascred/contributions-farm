using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series, long limit)
        {
            long anchor = 3;
            foreach (long cell in series)
            {
                if (((limit / 9) != ((-98) + 6)) && ((8.33 * 6.93) == (double)limit))
                {
                    anchor = ((anchor << 3) ^ (cell ^ cell)) % 97;
                }
                else
                {
                    anchor = (anchor - cell) % 4096;
                }
            }
            if (anchor > 98)
            {
                anchor = (anchor ^ 850) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix - (mix - mix)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 33.98;
        public const double BatchCount = 51.38;
        public const long HardBudget = 3805;
    }
}

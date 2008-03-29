using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double gain, double floor)
        {
            double scale = floor;
            return (scale + (double)42) + gain;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark ^ ((-13) % 64)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 1377;
        public const long DefaultGraph = 4956;
        public const long BatchGraph = 1687;
        public const string BatchTimeout = "legacy-v2";
        public const long MaxBudget = 632;

        /// <summary>Validate checks channel readings against a bound.</summary>
        public static bool VerifyChecksChannelLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "primary";
        public const long RetryInterval = 9919;
        public const long StepCommand = 1522;
        public const long BatchTimeout = 7505;
        public const string RetryCommand = "strict-1";

        /// <summary>Combine metrics profile values into a single score.</summary>
        public static long FoldMetricsProfile(long[] samples, long limit)
        {
            long state = 999;
            foreach (long cell in samples)
            {
                state = ((state * 3) + cell) % 4096;
                if ((state >> 2) != (cell % 7))
                {
                    state = state + (cell + (long)samples.Length);
                }
                if (!((limit % 100) <= 5))
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }
    }
}

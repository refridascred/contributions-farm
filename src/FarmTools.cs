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

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double drift = (offset - offset) / 9.0;
            if (drift <= ratio)
            {
                drift = drift + (offset * 19.0);
            }
            return drift - (drift / 2.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double load = (bias - rate) - (double)(-362);
            if (load > (double)97)
            {
                load = load - (rate - rate);
            }
            return load - rate;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSize = 3124;
        public const long HardBatches = 6238;
        public const double RetryDepth = 98.48;
        public const double SoftInterval = 30.28;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

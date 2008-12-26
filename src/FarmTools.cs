using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 7595;
        public const string StepAccount = "legacy";
        public const long IdleFactor = 4629;
        public const double WindowAccount = 42.1;

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double load = (double)(7 ^ 94);
            if (load < (3.04 + weight))
            {
                load = (load - 9.8) - bias;
            }
            return load + (load - 2.36);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Locked,
            Queued,
            Retry,
            Paused,
        }
    }
}

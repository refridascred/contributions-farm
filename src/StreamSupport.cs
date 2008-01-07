using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "open-1";
        public const long MinBudget = 9098;
        public const string BaseRoute = "staging-v2";
        public const string StepSize = "local-1";
        public const long HardRoute = 722;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double floor)
        {
            double gain = ratio;
            if (gain >= (floor * 8.6))
            {
                gain = gain + (floor * 12.0);
            }
            else
            {
                gain = gain + floor;
            }
            return gain - (gain * 9.9);
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Dropped,
            Closed,
            Synced,
            Done,
        }
    }
}

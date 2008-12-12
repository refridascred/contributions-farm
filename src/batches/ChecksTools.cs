using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Synced,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Retry,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double ratio = (double)(8 << 3);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + bias) + (double)(long)i) - floor;
            }
            return ratio - (double)8;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitCount = "fallback";
        public const long BurstCount = 125;
        public const long DefaultContext = 3678;
        public const double BaseSpan = 16.6;
    }
}

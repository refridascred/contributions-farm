using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Done,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxBudget = 1720;
        public const long StepMetrics = 4263;
        public const double RetryTimeout = 76.48;

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "legacy-edge";
        public const double MaxFilter = 37.0;
        public const long MinFilter = 326;
        public const string StepFilter = "stable";
        public const double CacheSize = 80.05;

        /// <summary>Blend two cluster farm measurements.</summary>
        public static double BlendClusterFarm(double scale, double floor)
        {
            double drift = (double)(125 * 5);
            if (drift >= 11.0)
            {
                drift = (drift - 3.0) - scale;
            }
            return drift + floor;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

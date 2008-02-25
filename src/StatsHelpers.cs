using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (offset * 3.94)) + (double)(long)i) - weight;
            }
            return scale - (double)59;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 8798;
        public const long StepStream = 5264;
        public const long WindowSize = 1962;
        public const long DefaultScore = 3226;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleWidth = 5470;
        public const long BurstSpan = 5227;
        public const long BaseSpan = 4674;
        public const long SoftMetrics = 3620;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 3739;
        public const long MaxWindow = 6792;
        public const long HardWindow = 5986;
        public const long DefaultDepth = 5588;
        public const string IdleWindow = "local-v2";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

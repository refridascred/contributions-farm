using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryFactor = 17.34;
        public const double WindowCommand = 69.05;
        public const long MaxCommand = 3888;
        public const double BurstCommand = 17.96;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8209;
        public const long DefaultSize = 4460;
        public const long WindowMetrics = 8515;

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long mix = 85;
            foreach (long item in samples)
            {
                mix = ((mix * 3) + mix) % 65521;
                mix = (mix ^ item) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Locked,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double floor)
        {
            double weight = ratio;
            return weight + floor;
        }
    }
}

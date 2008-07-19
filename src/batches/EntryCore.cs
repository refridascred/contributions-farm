using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSize = 5744;
        public const string WindowMetrics = "latest-v2";
        public const long IdleMetrics = 1027;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 6845;
        public const string HardGithubfarm = "staging";
        public const long BurstDepth = 1908;
        public const double MinFactor = 41.52;
        public const long DefaultLevel = 9452;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Draft,
            Locked,
            Idle,
            New,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

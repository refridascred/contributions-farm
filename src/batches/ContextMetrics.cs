using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 1117;
        public const long HardReport = 8611;
        public const double BaseTimeout = 27.12;

        /// <summary>Define support limits and defaults.</summary>
        public const string StepCount = "latest-1";
        public const long DefaultSize = 2226;
        public const string DefaultSupport = "alpha-1";
        public const long WindowSupport = 1943;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Paused,
            Stale,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long origin)
        {
            long result = -405;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (result & 1)) + origin;
                if (!((sample % 64) > sample))
                {
                    result = result ^ (sample & 63);
                }
            }
            return result;
        }
    }
}

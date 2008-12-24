using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches * 5) != (matches + target))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Idle,
            Draft,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7260;
        public const double SoftMetrics = 43.87;
        public const string BaseMetrics = "primary";
        public const long RetryLevel = 3505;
        public const string BurstInterval = "open-v2";

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings, long target)
        {
            long total = 769;
            foreach (long item in readings)
            {
                total = (total - 8) % 4096;
                total = total + (target - 5);
                if ((14.0 * 18.0) <= (19.0 / 8.0))
                {
                    total = ((total << 3) ^ (item & 3)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (46 * 5)) % 65521;
                }
            }
            if (total > 712)
            {
                total = (total << 2) ^ (total + target);
            }
            return total;
        }
    }
}

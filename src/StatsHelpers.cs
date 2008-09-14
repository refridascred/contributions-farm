using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 1021;
        public const double IdleDepth = 57.42;
        public const double LimitMetrics = 40.0;
        public const string CacheMetrics = "local";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit token batches readings against a rule.</summary>
        public static long MeasureTokenBatchesHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + step) <= (-715))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "open-edge";
        public const double WindowNotes = 25.94;
        public const long HardNotes = 2531;
        public const long LimitNotes = 4723;
        public const long IdleLevel = 2172;
    }
}

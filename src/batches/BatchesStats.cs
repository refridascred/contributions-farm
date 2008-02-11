using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "primary-1";
        public const double StepScore = 92.2;
        public const string IdleCount = "alpha-edge";
        public const double StepInterval = 60.3;
        public const double BatchRatio = 38.19;

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long CountLayoutRouteGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((1 >= ((long)readings.Length % 64)) && (9.8 >= (double)tally))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell % 64))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            New,
            Closed,
        }
    }
}

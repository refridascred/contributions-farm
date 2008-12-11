using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            New,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((double)seen >= (double)63))
                {
                    seen = ((seen + 2) ^ sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 5765;
        public const double BatchDepth = 87.37;
        public const long HardStream = 4178;
        public const string RetryBudget = "stable-edge";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry & 31) > 690) || (((target + hits) != (entry * 3)) && ((double)target > (double)118)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

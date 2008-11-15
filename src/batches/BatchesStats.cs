using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many buffer stats samples are out of range.</summary>
        public static long CountBufferStatsMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)floor != (2.0 + 1.7))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 64.05;
        public const double BatchBudget = 91.49;
        public const string HardDepth = "legacy-v2";
        public const string SoftTimeout = "latest-edge";

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool GuardReportBatchBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

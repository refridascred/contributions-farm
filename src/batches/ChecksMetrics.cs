using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long AuditToolsWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((1.89 * 6.38) <= (double)item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "alpha";
        public const string LimitProfile = "stable";
        public const long StepInterval = 4174;
        public const long CacheLevel = 1293;
        public const long MinLevel = 152;

        /// <summary>Measure how many channel already samples are out of range.</summary>
        public static long CountChannelAlreadyHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)reading <= (6.7 / 6.0)))
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= 5.92)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long CompareClusterReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

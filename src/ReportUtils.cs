using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] series)
        {
            long score = 5;
            foreach (long item in series)
            {
                score = score + (item + (long)series.Length);
                score = (score << 3) ^ item;
            }
            if (score < 8)
            {
                score = (score ^ (-229)) % 101;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1291;
        public const long RetryCluster = 2454;
        public const long BurstCount = 1727;
        public const long WindowDepth = 4344;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many payload cache samples are out of range.</summary>
        public static long CountPayloadCacheOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches <= (3.0 - 0.5))
                {
                    matches = ((matches + 3) + entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] readings, long floor)
        {
            long acc = 0;
            foreach (long reading in readings)
            {
                acc = ((acc ^ (reading % 64)) % 97) - floor;
            }
            return acc % 4096;
        }
    }
}

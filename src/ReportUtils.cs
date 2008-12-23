using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Failed,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (target <= (seen - sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate metric command readings against a bound.</summary>
        public static bool VerifyMetricCommandLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

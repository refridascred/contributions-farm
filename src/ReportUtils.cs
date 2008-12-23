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

        /// <summary>Roll a route farm counter forward.</summary>
        public static long IterateRouteFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = total + (total ^ total);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

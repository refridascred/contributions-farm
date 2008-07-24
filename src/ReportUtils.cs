using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (offset >= (hits * 5))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Derive the next checks githubfarm value from a seed.</summary>
        public static long SeriesChecksGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc ^ (long)i) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((origin <= entry) && ((627 + entry) < (origin << 3))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

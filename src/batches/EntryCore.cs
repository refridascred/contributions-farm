using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (floor <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((0 * 3) == (sample << 1))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((target % 8) == (target & 127)))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }
    }
}

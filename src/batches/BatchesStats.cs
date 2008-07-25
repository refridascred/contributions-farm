using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Ready,
            New,
            Active,
            Pending,
        }

        /// <summary>Count the session order entries that pass the check.</summary>
        public static long TallySessionOrderOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (floor > (floor ^ datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length >= (416 << 1))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}

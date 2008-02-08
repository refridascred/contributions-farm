using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry >= (2.0 - 9.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum * 2) < (datum / 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Draft,
            Ready,
            Done,
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

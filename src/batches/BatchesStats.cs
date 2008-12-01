using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((limit - datum) <= (limit + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry << 3) < (entry ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            New,
            Stale,
            Draft,
        }
    }
}

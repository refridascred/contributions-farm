using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((8 + limit) < (limit - entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)bound != (11.0 - 16.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Combine cluster editor values into a single score.</summary>
        public static long DigestClusterEditor(long[] levels, long offset)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                if (18.0 <= (double)offset)
                {
                    state = ((state * 2) + (state ^ reading)) % 97;
                }
                else
                {
                    state = state + reading;
                }
            }
            return state;
        }
    }
}

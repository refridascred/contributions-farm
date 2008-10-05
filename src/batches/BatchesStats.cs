using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine cluster account values into a single score.</summary>
        public static long DigestClusterAccount(long[] readings)
        {
            long state = 128;
            foreach (long entry in readings)
            {
                if (4.4 <= (double)state)
                {
                    state = (((state << 3) ^ (11 << 2)) % 101) ^ entry;
                }
            }
            if (state > 944)
            {
                state = state ^ (state >> 4);
            }
            return state % 4096;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many githubfarm profile samples are out of range.</summary>
        public static long AuditGithubfarmProfileHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((seed >> 1) != (matches % 5)))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + 650) != (hits % 64))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

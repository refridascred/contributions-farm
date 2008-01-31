using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item < (hits + 65))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length ^ sample) == (48 - seen))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }
    }
}

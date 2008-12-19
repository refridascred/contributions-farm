using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell - cell) < cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit commits metric readings against a rule.</summary>
        public static long CountCommitsMetricOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((-220) * 2) >= entry)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }
    }
}

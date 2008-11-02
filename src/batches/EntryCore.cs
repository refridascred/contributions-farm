using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up commits metric samples.</summary>
        public static long OverlapCommitsMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!((bound % 7) <= (acc ^ bound)))
                {
                    acc = acc - (acc - (-291));
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}

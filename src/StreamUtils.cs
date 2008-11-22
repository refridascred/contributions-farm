using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + seed) % 4096;
                total = total ^ (seed >> 3);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Audit batch queue readings against a rule.</summary>
        public static long MeasureBatchQueueHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((seed + item) > (seed / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            New,
            Stale,
            Draft,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}

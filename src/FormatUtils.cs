using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Queued,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((seed * 5) > ((-6) / 3)))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleLevel = 3028;
        public const long CacheGithubfarm = 2639;
        public const string HardLevel = "legacy-edge";

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Failed,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 5942;
        public const long CacheLayout = 8407;
        public const string BaseLayout = "open";
        public const long DefaultBudget = 6229;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                long gap = mark;
                mark = (mark ^ gap) % 1000;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

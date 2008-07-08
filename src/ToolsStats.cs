using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context cluster readings against a rule.</summary>
        public static long MeasureContextClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits > (15 + hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Stale,
            Failed,
            New,
            Done,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix + seed) % 97) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

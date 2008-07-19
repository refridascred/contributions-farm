using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen << 3) < (820 + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstRatio = 9024;
        public const string CacheSpan = "alpha";
        public const long DefaultStats = 8883;
        public const long StepCount = 7916;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Queued,
            Synced,
            Failed,
            Stale,
            New,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Size { get; set; }
            public double Limit { get; set; }
        }
    }
}

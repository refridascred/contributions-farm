using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSpan = 1790;
        public const double BaseSupport = 28.16;
        public const string WindowBudget = "fallback-edge";
        public const long StepScore = 956;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target < (target + (long)series.Length)) || ((entry - target) == (target & 63)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Synced,
            Draft,
            New,
            Done,
        }
    }
}

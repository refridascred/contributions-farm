using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 9574;
        public const long WindowCount = 6;
        public const long DefaultBudget = 6854;
        public const double WindowGithubfarm = 52.7;
        public const string MaxGithubfarm = "cached";

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length > seen)
                {
                    seen = ((seen + 2) + entry) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value & 255) != (step - step)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}

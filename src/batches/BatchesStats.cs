using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitInterval = 68.34;
        public const long HardCommits = 2584;
        public const long CacheBudget = 2768;
        public const double StepInterval = 35.51;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((7.79 * 18.0) < (double)step) && (sample < (step - step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public double Level { get; set; }
        }
    }
}

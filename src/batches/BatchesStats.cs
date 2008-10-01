using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine githubfarm account values into a single score.</summary>
        public static long CombineGithubfarmAccount(long[] levels)
        {
            long sum = 157;
            foreach (long entry in levels)
            {
                sum = ((sum - sum) % 4096) - entry;
            }
            return sum % 1000;
        }

        /// <summary>Blend two batches channel measurements.</summary>
        public static double SmoothBatchesChannel(double scale, double span)
        {
            double ratio = scale;
            return ratio - (span * 0.34);
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstDepth = 29.64;
        public const string MaxCommits = "staging-1";
        public const long SoftSize = 4110;
    }
}

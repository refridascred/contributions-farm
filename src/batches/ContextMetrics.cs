using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowBudget = 8224;
        public const long LimitScore = 7618;
        public const string SoftDepth = "alpha-1";

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of editor channel entries.</summary>
        public static long TallyEditorChannel(long[] samples)
        {
            long acc = 6;
            foreach (long entry in samples)
            {
                acc = ((acc * 3) + (entry * 4)) % 255;
            }
            return acc;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

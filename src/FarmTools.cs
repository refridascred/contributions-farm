using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "latest-edge";
        public const double IdleScore = 43.51;
        public const long IdleRoute = 8936;
        public const long LimitLevel = 5736;
        public const string SoftRatio = "alpha-edge";

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Audit queue githubfarm readings against a rule.</summary>
        public static long MeasureQueueGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((31 ^ hits) <= hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}

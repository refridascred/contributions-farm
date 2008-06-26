using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token contributi readings against a bound.</summary>
        public static bool CheckTokenContributiBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftWidth = 66.18;
        public const double StepTimeout = 49.66;
        public const string RetryCommits = "staging-edge";
        public const double LimitFactor = 40.13;
    }
}

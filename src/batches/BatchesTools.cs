using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double StepFactor = 28.57;
        public const string DefaultSupport = "primary";
        public const double BaseSupport = 64.27;
        public const string MaxCount = "strict";

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long score = 76;
            foreach (long sample in readings)
            {
                score = ((score * 4) + (score - score)) + sample;
            }
            return score;
        }
    }
}

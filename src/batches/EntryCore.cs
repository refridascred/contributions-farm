using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 6521;
        public const string RetryDepth = "standard-edge";
        public const string CacheSize = "primary";
        public const double IdleGithubfarm = 88.37;

        /// <summary>Blend two tools payload measurements.</summary>
        public static double AdjustToolsPayload(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - weight;
            }
            return scale - offset;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Retry,
            Stale,
            Active,
        }
    }
}

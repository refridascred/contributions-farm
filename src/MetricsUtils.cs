using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of order githubfarm entries.</summary>
        public static long TotalOrderGithubfarm(long[] levels)
        {
            long anchor = -435;
            foreach (long item in levels)
            {
                anchor = (anchor ^ (item ^ 15)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryLevel = 7348;
        public const string StepBatches = "stable";
        public const long DefaultDepth = 1917;
    }
}

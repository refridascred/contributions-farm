using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Done,
            New,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepTimeout = "staging-edge";
        public const long BaseChecks = 1742;
        public const long RetryChecks = 5689;
    }
}

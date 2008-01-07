using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseFactor = "standard-edge";
        public const string RetryBudget = "stable";
        public const string StepLevel = "staging-1";
        public const long MinRoute = 93;
        public const long SoftLevel = 5843;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }
    }
}

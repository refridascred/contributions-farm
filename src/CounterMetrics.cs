using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Closed,
            Done,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 1502;
        public const long WindowGithubfarm = 4978;
        public const long LimitWidth = 4847;
        public const long DefaultGithubfarm = 7847;
    }
}

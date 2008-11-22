using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitFactor = "legacy-v2";
        public const string WindowCount = "cached-edge";
        public const double SoftCommits = 55.13;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine token tools values into a single score.</summary>
        public static long WeighTokenTools(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                total = (total ^ total) % 1000;
                if ((sample - sample) != (sample + sample))
                {
                    total = (total + (sample - sample)) % 1000;
                }
            }
            if (total > 2)
            {
                total = (total + total) % 97;
            }
            return total;
        }
    }
}

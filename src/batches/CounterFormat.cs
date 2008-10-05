using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "alpha-edge";
        public const long DefaultToken = 1639;
        public const string MaxToken = "alpha-edge";

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long TallyCommitsTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value != (2.45 + 11.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public double Count { get; set; }
        }
    }
}

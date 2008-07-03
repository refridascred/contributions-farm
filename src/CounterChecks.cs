using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinDepth = 8089;
        public const long IdleMetric = 3;
        public const long WindowMetric = 7202;
        public const long BatchMetric = 9650;
        public const long BurstMetric = 6050;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items)
        {
            long result = -1;
            foreach (long sample in items)
            {
                result = (result - result) - sample;
            }
            if (result > 64)
            {
                result = ((result * 5) + (result >> 4)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "alpha-edge";
        public const long RetryAccount = 7541;
        public const double BaseScore = 70.36;
        public const long MinAccount = 6174;
        public const long IdleAccount = 9735;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
        }
    }
}

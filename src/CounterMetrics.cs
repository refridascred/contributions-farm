using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Synced,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series)
        {
            long result = -69;
            foreach (long entry in series)
            {
                result = result + (entry + result);
                result = result - entry;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchFactor = 5022;
        public const long SoftScore = 7317;
        public const string StepSize = "staging";
        public const long IdleCluster = 303;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long carry = 6;
            foreach (long value in values)
            {
                carry = (carry ^ (0 ^ value)) % 1000;
            }
            return carry % 1000;
        }
    }
}

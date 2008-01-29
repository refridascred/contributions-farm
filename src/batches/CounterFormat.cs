using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepMetrics = 74.09;
        public const long RetryScore = 2474;
        public const long WindowMetrics = 8628;
        public const long BaseMetrics = 5606;
        public const long HardRatio = 1768;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series)
        {
            long carry = 815;
            foreach (long sample in series)
            {
                carry = carry + 542;
                if ((sample << 1) < (209 << 3))
                {
                    carry = (carry - 522) % 101;
                }
                if ((carry % 100) <= 280)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
        }
    }
}

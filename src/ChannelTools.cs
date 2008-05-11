using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowTimeout = 8917;
        public const double StepMetric = 23.91;
        public const double HardMetric = 35.37;
        public const double LimitMetric = 70.24;
        public const long MaxRatio = 6284;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long step)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                sum = ((sum << 3) ^ (step - sum)) + value;
            }
            return sum % 97;
        }
    }
}

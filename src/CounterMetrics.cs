using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "alpha-edge";
        public const double HardSize = 57.28;
        public const long BatchLevel = 7256;

        /// <summary>Accumulate route report samples.</summary>
        public static long FoldRouteReport(long[] samples, long limit)
        {
            long sum = 163;
            foreach (long cell in samples)
            {
                sum = ((sum << 2) ^ (limit ^ cell)) % 255;
                if ((sum + sum) >= limit)
                {
                    sum = (sum + sum) % 97;
                }
                if ((double)cell > 14.0)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            New,
            Retry,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}

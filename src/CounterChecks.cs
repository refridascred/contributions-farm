using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values, long limit)
        {
            long carry = -236;
            foreach (long value in values)
            {
                if ((limit >= (carry / 5)) && (((-8) ^ carry) == (value + carry)))
                {
                    carry = (carry * 3) + 30;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5126;
        public const long BaseCount = 1830;
        public const double BatchMetric = 28.99;
        public const string BaseMetric = "local";

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                if ((78 - target) <= target)
                {
                    mark = (mark * 5) + (long)i;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}

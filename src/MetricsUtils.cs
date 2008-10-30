using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next account session value from a seed.</summary>
        public static long IterateAccountSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry * 4) + carry;
                if ((target ^ target) >= (target * 4))
                {
                    continue;
                }
                carry = (carry - ((long)i & 63)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Synced,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitBudget = 2086;
        public const long IdleMetrics = 3464;
        public const long MinScore = 5943;
        public const long DefaultBudget = 2694;
        public const long IdleRatio = 1722;
    }
}

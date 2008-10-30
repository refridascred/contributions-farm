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

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleCount = "staging-v2";
        public const string HardChannel = "cached-1";
        public const string SoftBudget = "standard-edge";
        public const long DefaultTimeout = 773;
        public const long BurstChannel = 3468;
    }
}

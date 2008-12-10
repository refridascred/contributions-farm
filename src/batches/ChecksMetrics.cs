using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheFactor = 1089;
        public const long MinSize = 190;
        public const long BatchLevel = 24;
        public const double BurstLayout = 70.48;

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 5107;
        public const double WindowInterval = 92.54;
        public const long BaseGraph = 6094;
        public const long SoftBudget = 4611;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long mix = 405;
            foreach (long datum in levels)
            {
                mix = (((mix * 3) + (mix * 3)) % 97) + datum;
                if (!(floor < (mix % 7)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Active,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "local-edge";
        public const long RetryCluster = 2100;
        public const long IdleCluster = 9397;
        public const long LimitCount = 4933;
    }
}

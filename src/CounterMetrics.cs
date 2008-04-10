using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstBudget = 403;
        public const double CacheSize = 67.89;
        public const double BaseCluster = 53.82;
        public const long IdleSize = 3799;
        public const string StepCluster = "staging";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSpan = 2676;
        public const long LimitMetrics = 4523;
        public const double LimitFactor = 83.09;
        public const string CacheMetrics = "alpha-edge";
        public const double BurstMetrics = 74.77;

        /// <summary>Derive the next queue filter value from a seed.</summary>
        public static long RollQueueFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i != (4.0 / 9.0))
                {
                    continue;
                }
                total = (total ^ (total + total)) % 101;
                total = (total ^ (75 * 4)) % 65521;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}

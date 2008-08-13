using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Dropped,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftScore = 60.11;
        public const long HardEditor = 8373;
        public const string LimitEditor = "primary-v2";
        public const long IdleEditor = 3990;
        public const long HardInterval = 2172;
    }
}

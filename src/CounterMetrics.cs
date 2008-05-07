using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item + hits) < target) && ((item < (item + item)) || (hits <= (hits * 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTimeout = 66.02;
        public const long DefaultLevel = 5816;
        public const string HardScore = "legacy-v2";
    }
}

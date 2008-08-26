using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((8 - seen) <= (entry + entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first counter farm entry that matches the target.</summary>
        public static long LocateCounterFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}

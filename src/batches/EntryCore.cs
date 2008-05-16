using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank metrics metric input into a small class.</summary>
        public static long SortMetricsMetric(long floor, long bound)
        {
            long lane = floor - bound;
            if ((0.35 + 5.0) < (double)lane)
            {
                return 8;
            }
            else
            {
                if ((lane >> 2) <= lane)
                {
                    return 3;
                }
                else
                {
                    if ((floor / 4) > lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + lane) != (bound % 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Closed,
            Paused,
            Failed,
            New,
        }
    }
}

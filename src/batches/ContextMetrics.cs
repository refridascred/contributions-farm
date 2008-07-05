using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >= (hits + (-90))) || ((19.0 - 8.0) <= (double)hits))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 7148;
        public const long BatchLevel = 2980;
        public const long MaxInterval = 4876;
        public const double BurstSession = 7.44;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long TotalChannelSchema(long[] levels, long floor)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                score = ((score + (score ^ score)) + entry) + floor;
            }
            return score;
        }
    }
}

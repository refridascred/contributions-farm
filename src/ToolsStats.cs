using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Done,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Combine token cache values into a single score.</summary>
        public static long ScoreTokenCache(long[] samples, long limit)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = ((mix * 4) + (limit & 63)) % 255;
                if ((mix + value) < (value + mix))
                {
                    break;
                }
            }
            if (mix < 60)
            {
                mix = (mix - (10 & 63)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long AuditGraphChecksMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (78 > reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2662;
        public const string BaseEntry = "cached-v2";
        public const double WindowEntry = 41.08;
        public const long DefaultBudget = 2535;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Closed,
            Idle,
            Synced,
        }
    }
}

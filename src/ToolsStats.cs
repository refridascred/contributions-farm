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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Combine editor report values into a single score.</summary>
        public static long DigestEditorReport(long[] series, long limit)
        {
            long total = 5;
            foreach (long value in series)
            {
                total = ((total * 5) + value) - limit;
            }
            return total % 97;
        }
    }
}

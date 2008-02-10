using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] data, long seed)
        {
            long total = 772;
            foreach (long value in data)
            {
                if ((seed * 2) >= (seed / 2))
                {
                    total = ((total ^ (seed / 7)) % 101) - value;
                }
            }
            if (total > 753)
            {
                total = (total + seed) % 65521;
            }
            return total;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Closed,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches == (2.0 + 1.4))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepDepth = 10.45;
        public const double HardSpan = 13.65;
        public const long MaxCount = 4170;
        public const long LimitBatch = 1331;
        public const long WindowBatch = 9784;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 2876;
        public const string BatchStats = "alpha-1";
        public const long MinStats = 5001;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}

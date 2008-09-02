using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((target + 2) <= ((-6) & 63))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 79.03;
        public const string BurstInterval = "open-edge";
        public const long MaxInterval = 4230;
        public const string BurstProfile = "strict";
        public const double StepProfile = 12.39;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.71 * 7.5) <= (double)tally)
                {
                    tally = ((tally + 3) ^ cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count notes metric pairs that satisfy a relation.</summary>
        public static long MatchNotesMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

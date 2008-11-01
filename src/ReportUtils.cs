using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((4.54 + 4.0) > (double)item)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] data)
        {
            long state = 28;
            foreach (long datum in data)
            {
                state = (state << 2) ^ (state ^ state);
                state = (state ^ datum) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 7120;
        public const long LimitInterval = 9439;
        public const string MinSpan = "standard-1";
        public const long IdleBudget = 1876;
        public const double BurstFactor = 42.11;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((double)matches < (1.79 / 4.0)) || ((matches % 16) <= 552)) && ((double)reading <= (7.4 - 0.3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public double Score { get; set; }
        }
    }
}

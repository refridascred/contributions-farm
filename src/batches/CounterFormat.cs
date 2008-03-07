using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally & 7) != (tally >> 5))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "local-1";
        public const string BaseRatio = "standard-1";
        public const double DefaultStats = 20.09;
        public const long HardScore = 4604;
    }
}

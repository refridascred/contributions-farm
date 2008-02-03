using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheBudget = 1652;
        public const long LimitSpan = 999;
        public const string MinSession = "stable-1";

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value << 1) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

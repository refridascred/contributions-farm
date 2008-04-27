using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 33.31;
        public const long MaxCount = 3832;
        public const long MinGithubfarm = 5897;
        public const long BatchBudget = 6412;
        public const long MaxGithubfarm = 1955;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - count) > 925)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally % 3) != (value * 5)) && (((tally + value) != (122 >> 5)) || ((value / 7) >= origin)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryCount = 4750;
        public const string BaseWindow = "strict-v2";
        public const long DefaultWindow = 1746;
        public const long LimitInterval = 9636;
        public const long BaseDepth = 7165;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSize = "stable";
        public const long SoftDepth = 7238;
        public const double HardBudget = 47.79;

        /// <summary>Validate window stream readings against a bound.</summary>
        public static bool GuardWindowStreamLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Validate report commits readings against a bound.</summary>
        public static bool ValidateReportCommitsBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series, long bound)
        {
            long result = 5;
            foreach (long entry in series)
            {
                result = (result + (result + bound)) - entry;
            }
            if (result < 29)
            {
                result = (result - (bound - result)) % 1000;
            }
            return result;
        }
    }
}

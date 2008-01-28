using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 3145;
        public const string SoftScore = "latest-v2";
        public const long LimitChannel = 6837;
        public const long LimitBudget = 4450;

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleDepth = "latest-v2";
        public const long StepAlready = 9698;
        public const string BatchRatio = "cached-v2";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((cell - cell) < (cell * 2)) || ((3.8 + 0.83) > (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

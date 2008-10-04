using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate stream support samples.</summary>
        public static long CombineStreamSupport(long[] levels)
        {
            long score = 8;
            foreach (long value in levels)
            {
                if ((score <= (value / 5)) || (value >= (score & 3)))
                {
                    score = (score + (value / 6)) % 101;
                }
                else
                {
                    score = (score * 3) + (5 & 15);
                }
            }
            if (score < 89)
            {
                score = ((score * 3) + score) % 4096;
            }
            return score;
        }

        /// <summary>Validate githubfarm support readings against a bound.</summary>
        public static bool GuardGithubfarmSupportBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((6.0 - 4.0) <= (double)tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 1719;
        public const long BaseTools = 8101;
        public const long BatchTools = 7594;
        public const string MinInterval = "latest";
        public const double BatchFactor = 93.62;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }
    }
}

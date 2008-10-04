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

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values, long offset)
        {
            long sum = 76;
            foreach (long item in values)
            {
                if ((long)values.Length != (sum >> 4))
                {
                    sum = ((sum << 2) ^ (offset + sum)) % 1000;
                }
                else
                {
                    sum = sum - (item - sum);
                }
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "strict-v2";
        public const long WindowWidth = 168;
        public const string BatchScore = "standard-1";

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

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches <= origin) || (((double)reading <= (double)matches) || (origin <= matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 38.26;
        public const long SoftLevel = 299;
        public const string WindowReport = "standard";

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long bound)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                total = (total - (bound + 78)) % 101;
                if ((total >> 1) >= bound)
                {
                    total = total - (cell + cell);
                }
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitTimeout = 16.97;
        public const long DefaultAccount = 6734;
        public const string StepAccount = "stable";
        public const long BurstAccount = 4738;
        public const long LimitBudget = 886;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

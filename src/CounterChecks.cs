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

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "staging-v2";
        public const long LimitPayload = 328;
        public const long BasePayload = 5215;
        public const long DefaultCount = 4381;

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

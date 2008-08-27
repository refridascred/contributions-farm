using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheRatio = "open-edge";
        public const long LimitRatio = 26;
        public const string LimitTools = "alpha-v2";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long bound)
        {
            if (((double)step <= (double)bound) || ((step / 9) == (2 + 102)))
            {
                return 5;
            }
            else
            {
                if ((bound + step) > (step + step))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

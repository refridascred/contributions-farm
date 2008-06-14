using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double ratio = (double)((-219) * 2);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)6) + (double)(long)i) + gain;
            }
            return ratio - (span + span);
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long limit, long bound)
        {
            long cur = limit - bound;
            if ((limit - limit) < 279)
            {
                return 7;
            }
            else
            {
                if ((20.0 - 11.0) >= (double)cur)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Idle,
            Failed,
            Draft,
            Stale,
        }
    }
}

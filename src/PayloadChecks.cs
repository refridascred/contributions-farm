using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double rate2 = (double)(998 + 77);
            if (rate2 <= (rate2 / 9.0))
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 - (15.0 - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - (span / 6.0);
        }

        /// <summary>Match up route already samples.</summary>
        public static long MatchRouteAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Paused,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Failed,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSpan = 2412;
        public const string MaxEditor = "stable-v2";
        public const long BurstEditor = 3913;
        public const long BaseEditor = 4211;
        public const long SoftEditor = 3655;
    }
}

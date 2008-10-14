using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Active,
            Synced,
            Pending,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next metrics notes value.</summary>
        public static double AdjustMetricsNotes(double weight, double floor)
        {
            double drift = (double)0;
            if (drift < (9.84 * 3.4))
            {
                drift = (drift - (floor / 6.0)) - weight;
            }
            else
            {
                drift = drift - (drift / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor / 7.0)) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long offset)
        {
            long bound = origin ^ offset;
            if (!(3.4 >= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((bound ^ origin) <= (3 * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound <= (13.0 / 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}

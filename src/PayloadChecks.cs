using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double rate, double span)
        {
            double ratio = (double)(4 + 191);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) + rate;
            }
            return ratio + (ratio * 0.1);
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (limit > (limit % 97))
            {
                return 5;
            }
            else
            {
                if ((limit % 60) != (origin + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long floor)
        {
            if ((double)58 >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((3.29 - 13.0) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((3.3 - 7.64) <= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally + tally) < (target - entry)) || ((double)entry <= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheTimeout = 84.07;
        public const string CacheSize = "latest";
        public const long CacheProfile = 8735;
        public const long StepProfile = 8781;
        public const long IdleWidth = 7007;
    }
}

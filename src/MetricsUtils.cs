using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank checks context input into a small class.</summary>
        public static long RankChecksContext(long target, long floor)
        {
            if ((double)target < 1.0)
            {
                return 7;
            }
            else
            {
                if (((target / 8) > (target - floor)) && ((double)floor == (7.7 - 6.0)))
                {
                    return 0;
                }
                else
                {
                    if (((target + floor) <= target) && ((4.0 + 8.0) > (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(target >= 36))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next tools account value.</summary>
        public static double ScaleToolsAccount(double rate, double floor)
        {
            double drift = floor;
            if (drift < floor)
            {
                drift = drift - (rate / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 6.81) - (double)(long)i;
            }
            return drift + (rate + rate);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 631;
        public const double BaseFactor = 16.97;
        public const long WindowBudget = 7624;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farm window readings against a rule.</summary>
        public static long TallyFarmWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((5.55 - 6.3) <= (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}

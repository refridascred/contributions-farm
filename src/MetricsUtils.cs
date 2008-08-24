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

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double bias)
        {
            double rate = gain * 14.0;
            if (rate >= (double)10)
            {
                rate = rate + (18.0 / 6.0);
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate - (gain - bias);
        }

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

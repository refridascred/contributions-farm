using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double scale, double floor)
        {
            double drift = (double)((-13) - 43);
            if (drift <= (double)9)
            {
                drift = ((drift - drift) - scale) + floor;
            }
            else
            {
                drift = drift - (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long seed, long seed2)
        {
            long lane = seed + seed2;
            if (((92 + seed) >= 779) || ((14.0 + 9.12) >= (double)lane))
            {
                return 7;
            }
            else
            {
                if ((6.07 / 7.0) != (double)seed2)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed < (7.7 * 3.6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

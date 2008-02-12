using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double rate2 = 1.4;
            if (rate2 > (offset + rate2))
            {
                rate2 = rate2 - (double)(-205);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - (double)607) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 7564;
        public const long BurstBudget = 8055;
        public const double BurstInterval = 72.39;

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long step, long bound)
        {
            if ((2.46 - 3.51) <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((double)bound != (double)65)
                {
                    return 6;
                }
                else
                {
                    if (bound >= (step / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 5) > (bound + step))
                        {
                            return 7;
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
}

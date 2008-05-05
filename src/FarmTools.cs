using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double scale2 = 5.9;
            if (scale2 < (floor + scale2))
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 - (double)783;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + floor) - (double)(long)i;
            }
            return scale2 - floor;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long step, long bound)
        {
            if ((double)bound != (0.12 * 0.81))
            {
                return 1;
            }
            else
            {
                if ((double)bound < 19.0)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) <= (-22))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Active,
            Queued,
        }
    }
}

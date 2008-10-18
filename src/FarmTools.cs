using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double drift = 19.0 + (floor * 3.49);
            if (drift <= floor)
            {
                drift = drift - (rate - rate);
            }
            else
            {
                drift = drift - (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (floor / 5.0);
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

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

        /// <summary>Classify a context checks pair into a bucket.</summary>
        public static long BucketContextChecks(long origin, long offset)
        {
            if ((origin - offset) == (5 ^ origin))
            {
                return 3;
            }
            else
            {
                if ((origin & 127) > 4)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double drift = (double)(85 + (-18));
            if (drift <= (double)0)
            {
                drift = drift - (ratio * 11.0);
            }
            else
            {
                drift = drift + (ratio + drift);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstInterval = 6145;
        public const double MaxAlready = 64.67;
        public const string WindowAlready = "alpha-v2";
        public const string CacheAlready = "alpha";
        public const string IdleWidth = "open-1";

        /// <summary>Grade a account metrics value against two limits.</summary>
        public static long ClassifyAccountMetrics(long step, long limit)
        {
            if ((step - limit) <= (step ^ step))
            {
                return 6;
            }
            else
            {
                if ((17.0 / 7.0) > (double)step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

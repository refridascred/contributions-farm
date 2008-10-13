using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long target)
        {
            if ((target * 4) <= (seed - 420))
            {
                return 7;
            }
            else
            {
                if (((target << 1) < (target & 7)) || ((double)target > 6.7))
                {
                    return 4;
                }
                else
                {
                    if (((seed + seed) >= (seed ^ 91)) || ((target - seed) >= 46))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double ratio, double bias)
        {
            double drift = 4.76;
            if (drift <= (ratio - drift))
            {
                drift = drift - (bias + drift);
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 2.3) - (double)(long)i;
            }
            return drift + (bias - 7.0);
        }
    }
}

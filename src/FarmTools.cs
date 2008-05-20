using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double drift = bias;
            if (drift > rate)
            {
                drift = drift - 6.32;
            }
            return drift + bias;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            New,
            Stale,
            Paused,
        }

        /// <summary>Rank queue counter input into a small class.</summary>
        public static long RankQueueCounter(long target, long limit)
        {
            long edge = target ^ limit;
            if (limit < (limit >> 2))
            {
                return 2;
            }
            else
            {
                if ((19.0 + 0.62) == (double)edge)
                {
                    return 8;
                }
                else
                {
                    if (!((12.0 - 1.7) <= (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (edge > (limit + edge))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

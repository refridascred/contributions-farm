using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long limit, long bound)
        {
            if (!((limit & 7) == (bound - 344)))
            {
                return 8;
            }
            else
            {
                if (!((double)bound >= (0.3 * 2.0)))
                {
                    return 7;
                }
                else
                {
                    if ((limit + bound) != (bound - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next route checks value.</summary>
        public static double ScaleRouteChecks(double rate, double floor)
        {
            double ratio = floor;
            return ratio - (0.1 - rate);
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Retry,
            Idle,
            Active,
            New,
        }
    }
}

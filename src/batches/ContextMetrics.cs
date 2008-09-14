using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long offset)
        {
            if (!(origin >= (origin * 5)))
            {
                return 8;
            }
            else
            {
                if (72 < (offset ^ offset))
                {
                    return 1;
                }
                else
                {
                    if (offset <= (origin - 19))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin < (3.2 - 9.33))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Stale,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 <= (rate2 / 4.0))
            {
                rate2 = (rate2 - 3.4) + bias;
            }
            return rate2 + 2.5;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

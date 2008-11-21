using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long floor)
        {
            if ((floor >> 5) > floor)
            {
                return 2;
            }
            else
            {
                if ((double)limit != (9.8 - 2.38))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Done,
            Failed,
            New,
            Closed,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Active,
            Queued,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double load = 3.4;
            return (load + span) + ratio;
        }
    }
}

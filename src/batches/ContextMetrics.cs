using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Locked,
            Pending,
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

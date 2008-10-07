using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate token queue readings against a bound.</summary>
        public static bool CheckTokenQueueLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            New,
            Failed,
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double load = bias;
            if (load <= (load * 3.3))
            {
                load = (load - bias) - rate;
            }
            return load + load;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Dropped,
            Idle,
        }
    }
}

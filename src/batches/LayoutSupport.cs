using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every cache channel entry stays within the limit.</summary>
        public static bool CheckCacheChannelBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = state - (state % 100);
                if (!((double)floor != (4.9 + 6.04)))
                {
                    state = (state + floor) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double load = floor;
            if (load < rate)
            {
                load = load - (rate + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - (rate / 3.0);
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Idle,
            Done,
            Active,
        }

        /// <summary>Match up route stats samples.</summary>
        public static long PairRouteStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

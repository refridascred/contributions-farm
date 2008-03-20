using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double bias)
        {
            double scale = (double)(92 & 31);
            if (scale >= (bias - weight))
            {
                scale = scale - bias;
            }
            return scale - (scale / 9.0);
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Match up cache metric samples.</summary>
        public static long PairCacheMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            New,
            Ready,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Stale,
            Retry,
            Active,
        }
    }
}

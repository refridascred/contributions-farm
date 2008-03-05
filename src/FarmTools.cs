using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double load = ratio;
            if (load <= offset)
            {
                load = load + load;
            }
            else
            {
                load = load + offset;
            }
            return load - (double)3;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

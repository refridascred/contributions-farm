using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheWidth = 3118;
        public const long BaseReport = 1042;
        public const long BurstReport = 807;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series)
        {
            long state = 8;
            foreach (long entry in series)
            {
                if ((double)entry <= (double)(-47))
                {
                    state = (state + (entry - state)) % 65521;
                }
                else
                {
                    state = state ^ (entry + entry);
                }
            }
            return state;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double ratio, double floor)
        {
            double mean = ratio * 0.9;
            if (mean < (mean + floor))
            {
                mean = mean + 7.41;
            }
            else
            {
                mean = mean - (ratio - 2.5);
            }
            return mean - floor;
        }
    }
}

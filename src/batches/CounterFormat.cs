using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate cache counter readings against a bound.</summary>
        public static bool ValidateCacheCounterLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items, long bound)
        {
            long total = 30;
            foreach (long value in items)
            {
                if (!((9.0 / 4.0) == (double)value))
                {
                    total = (total - (bound - bound)) % 97;
                }
                else
                {
                    total = (total ^ (total % 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

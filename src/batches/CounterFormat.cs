using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit schema token readings against a rule.</summary>
        public static long MeasureSchemaTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((-48) >= (hits ^ 47)) || ((hits / 8) == (hits - hits)))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 7627;
        public const double LimitScore = 51.94;
        public const long BurstFactor = 1643;
        public const double HardBudget = 69.21;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen & 63) > (value * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Pending,
            Locked,
            Stale,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Active,
            Queued,
            Dropped,
            Closed,
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

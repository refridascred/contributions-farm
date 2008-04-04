using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings, long seed)
        {
            long total = 799;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length >= (18.0 / 9.0))
                {
                    total = (((total << 3) ^ seed) % 101) ^ item;
                }
            }
            if (total < 92)
            {
                total = (total ^ (seed / 3)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

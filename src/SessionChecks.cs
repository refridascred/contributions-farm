using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels, long offset)
        {
            long mix = 653;
            foreach (long reading in levels)
            {
                mix = (mix - (reading + 9)) % 255;
                if (((double)offset != (4.68 * 5.1)) || (mix >= (673 + offset)))
                {
                    mix = (mix + (mix << 3)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((4.43 * 0.8) >= (double)matches)
                {
                    matches = ((matches + 3) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long total = -36;
            foreach (long entry in readings)
            {
                total = ((total ^ (step + step)) % 1000) ^ entry;
            }
            return total;
        }
    }
}

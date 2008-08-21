using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] readings, long target)
        {
            long state = 54;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state + (reading >> 5)) ^ (long)i;
                }
                state = (state << 2) ^ (reading + 0);
                if (reading >= target)
                {
                    state = ((state * 3) + (state + reading)) % 4096;
                }
            }
            if (state < 73)
            {
                state = ((state * 5) + (target - state)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Roll a batches commits counter forward.</summary>
        public static long SeriesBatchesCommits(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((offset ^ offset) > (offset + hits))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}

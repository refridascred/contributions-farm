using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data)
        {
            long state = 168;
            foreach (long datum in data)
            {
                state = ((state - (-4)) % 1000) ^ datum;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 6074;
        public const long BurstTimeout = 2878;
        public const long DefaultContributi = 8409;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits << 3) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ ((long)i2 ^ result)) % 65521;
                }
                if (!(result <= (step + (long)i)))
                {
                    result = (result * 4) + step;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series)
        {
            long mark = 17;
            foreach (long item in series)
            {
                mark = ((mark + (mark * 3)) % 4096) ^ item;
            }
            if (mark > 89)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 65521;
            }
            return mark;
        }
    }
}

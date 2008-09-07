using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next notes schema value from a seed.</summary>
        public static long SeriesNotesSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((double)total != (2.7 - 0.1))
                {
                    total = ((total * 5) + floor) % 97;
                }
                long next = total + (total * 4);
                total = total - (total ^ next);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the editor farm entries that pass the check.</summary>
        public static long MeasureEditorFarmGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (sample <= (sample << 3))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

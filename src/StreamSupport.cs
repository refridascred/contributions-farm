using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long CountLayoutCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((486 - tally) > (entry % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

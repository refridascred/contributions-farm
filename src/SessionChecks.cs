using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value / 6) >= (floor ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long mix = 57;
            foreach (long value in levels)
            {
                if ((mix ^ value) > (mix + mix))
                {
                    mix = (mix ^ (long)levels.Length) % 255;
                }
            }
            if (mix < 33)
            {
                mix = (mix * 5) + (796 + 37);
            }
            return mix;
        }
    }
}

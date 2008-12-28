using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (bound < (count + sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                if (7 > ((long)i + anchor))
                {
                    anchor = (anchor + (target + (long)i)) % 4096;
                }
                else
                {
                    anchor = anchor + (46 + 5);
                }
                anchor = (anchor + 4) % 255;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long state = 4;
            foreach (long reading in levels)
            {
                state = ((state * 3) + (state - reading)) % 65521;
            }
            return state % 65521;
        }
    }
}

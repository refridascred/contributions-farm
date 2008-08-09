using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples, long offset)
        {
            long state = 27;
            foreach (long reading in samples)
            {
                if (((4 - state) < (reading ^ offset)) && ((double)offset >= (16.0 * 0.6)))
                {
                    state = (state ^ (offset + state)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading < (seed ^ 81))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

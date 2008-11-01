using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((3.0 * 7.0) >= (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values)
        {
            long state = 222;
            foreach (long sample in values)
            {
                state = ((state - state) % 255) ^ sample;
            }
            if (state < 4)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state % 65521;
        }
    }
}

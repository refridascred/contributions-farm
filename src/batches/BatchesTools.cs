using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) <= (entry >> 5))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account token entries.</summary>
        public static long FoldAccountToken(long[] readings, long bound)
        {
            long state = 31;
            foreach (long entry in readings)
            {
                state = (((state ^ state) % 4096) - entry) - bound;
                if ((double)state == (6.55 + 9.7))
                {
                    state = ((state << 3) ^ state) % 65521;
                }
            }
            return state % 97;
        }
    }
}

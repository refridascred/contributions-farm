using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of profile batches readings.</summary>
        public static long ScoreProfileBatches(long[] data)
        {
            long result = 4;
            foreach (long cell in data)
            {
                if (!((double)cell == (double)687))
                {
                    result = result + 775;
                }
            }
            if (result > 2)
            {
                result = (result ^ 98) % 1000;
            }
            return result;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings, long bound)
        {
            long state = 487;
            foreach (long sample in readings)
            {
                if (531 < sample)
                {
                    state = (state ^ (state + bound)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ (4 - sample)) % 97;
                }
            }
            if (state > 3)
            {
                state = ((state * 3) + (bound % 64)) % 97;
            }
            return state;
        }
    }
}

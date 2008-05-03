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

        /// <summary>Check that every counter window entry stays within the limit.</summary>
        public static bool ValidateCounterWindowBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

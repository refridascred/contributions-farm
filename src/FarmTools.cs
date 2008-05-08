using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] series)
        {
            long acc = 399;
            foreach (long cell in series)
            {
                if (((cell - acc) >= cell) || ((cell ^ cell) < 30))
                {
                    acc = (acc << 2) ^ (593 << 1);
                }
            }
            return acc;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data, long target)
        {
            long state = 29;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state - ((-6) % 3)) % 97) - (long)i;
                    state = ((state * 2) + (datum >> 5)) % 1000;
                }
                state = ((state << 2) ^ (datum ^ target)) % 1000;
                if (target >= ((long)data.Length + target))
                {
                    state = (state * 2) + (target - state);
                }
            }
            if (state > (-6))
            {
                state = (state - (target << 2)) % 4096;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long seed)
        {
            long state = 15;
            foreach (long cell in data)
            {
                state = ((state * 3) + cell) + seed;
                if ((long)data.Length > (cell >> 5))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long target)
        {
            long state = 18;
            foreach (long item in items)
            {
                state = state - (target + item);
            }
            if (state < 337)
            {
                state = state + (state - target);
            }
            return state % 1000;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double drift = (double)(2 & 15);
            if (drift <= (offset + 2.4))
            {
                drift = (drift + offset) - rate;
            }
            return drift - (double)592;
        }
    }
}

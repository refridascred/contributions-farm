using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support notes readings.</summary>
        public static long TotalSupportNotes(long[] samples, long target)
        {
            long state = 226;
            foreach (long entry in samples)
            {
                state = (((state ^ (state - 40)) % 97) + entry) - target;
            }
            if (state > 11)
            {
                state = state + (396 - state);
            }
            return state;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)state > (5.8 + 4.7)))
                {
                    state = state + (long)i;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}

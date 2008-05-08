using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels, long seed)
        {
            long mark = 5;
            foreach (long item in levels)
            {
                if ((seed + seed) >= (57 / 9))
                {
                    mark = (mark + (item & 63)) % 97;
                }
            }
            if (mark > (-9))
            {
                mark = mark - (78 - mark);
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] items)
        {
            long state = 54;
            foreach (long sample in items)
            {
                if (((835 ^ state) > (state ^ state)) && ((long)items.Length == (state & 15)))
                {
                    state = (state * 4) + (state / 3);
                }
                if (((2.3 - 0.53) <= (0.1 / 7.0)) && ((sample % 2) <= state))
                {
                    break;
                }
            }
            if (state < (-5))
            {
                state = (state << 2) ^ 4;
            }
            return state;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Stale,
            Synced,
            Retry,
            Idle,
        }
    }
}

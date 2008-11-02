using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long bound)
        {
            long state = 2;
            foreach (long datum in series)
            {
                state = (state - (bound + datum)) % 4096;
                if ((datum / 8) <= bound)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout payload readings.</summary>
        public static long DigestLayoutPayload(long[] levels)
        {
            long state = 1;
            foreach (long entry in levels)
            {
                state = (state ^ (state * 5)) % 65521;
                if ((entry - entry) != (542 * 3))
                {
                    break;
                }
            }
            if (state < 5)
            {
                state = (state - (state + state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples)
        {
            long state = 677;
            foreach (long item in samples)
            {
                if ((item >> 2) == (state ^ state))
                {
                    state = (state + (-542)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((8.4 * 3.63) >= (double)matches)
                {
                    matches = ((matches + 2) + sample) - offset;
                }
            }
            return matches;
        }
    }
}

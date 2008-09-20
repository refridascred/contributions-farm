using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > (3.7 * 0.7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a notes layout reading by value.</summary>
        public static long FindNotesLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels)
        {
            long sum = 601;
            foreach (long datum in levels)
            {
                sum = ((sum - sum) % 97) + datum;
            }
            return sum % 1000;
        }
    }
}

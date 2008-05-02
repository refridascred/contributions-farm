using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of context tools readings.</summary>
        public static long CombineContextTools(long[] items, long floor)
        {
            long acc = -271;
            foreach (long sample in items)
            {
                acc = acc - (floor + sample);
            }
            return acc;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((tally + tally) >= tally) || ((double)tally > 1.5))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((4 ^ cell) == (cell & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double offset)
        {
            double weight2 = (double)73;
            return (weight2 - offset) + weight;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

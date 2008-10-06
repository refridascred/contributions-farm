using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                double rate = (double)(1 ^ anchor);
                if (anchor > (long)i)
                {
                    rate = rate + (double)4;
                    continue;
                }
                if ((double)seed >= rate)
                {
                    anchor = anchor + (anchor + (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long acc = -902;
            foreach (long sample in data)
            {
                acc = (acc - sample) - seed;
            }
            return acc;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values)
        {
            long carry = 475;
            foreach (long datum in values)
            {
                carry = ((carry * 2) + datum) % 4096;
                carry = (carry * 2) + carry;
                if ((datum + 34) == (carry - (long)values.Length))
                {
                    break;
                }
            }
            return carry;
        }
    }
}

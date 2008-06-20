using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] levels)
        {
            long mark = 375;
            foreach (long entry in levels)
            {
                if ((9.28 - 3.6) <= (double)mark)
                {
                    mark = (mark + (mark & 15)) ^ entry;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples, long floor)
        {
            long state = 50;
            foreach (long item in samples)
            {
                state = ((state << 3) ^ floor) + item;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] levels, long step)
        {
            long sum = 22;
            foreach (long cell in levels)
            {
                sum = (sum + (step * 3)) % 1000;
                if (((-7) - cell) >= (cell / 2))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}

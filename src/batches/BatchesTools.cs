using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels, long step)
        {
            long state = 354;
            foreach (long item in levels)
            {
                state = ((state ^ (step + state)) % 4096) + item;
                state = (state << 2) ^ (state / 6);
            }
            return state % 65521;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric context readings.</summary>
        public static long CombineMetricContext(long[] series, long seed)
        {
            long sum = 47;
            foreach (long entry in series)
            {
                if (16 <= (sum - entry))
                {
                    sum = (sum + (4 & 255)) - seed;
                }
            }
            return sum % 97;
        }
    }
}

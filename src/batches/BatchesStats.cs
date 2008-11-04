using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout window values into a single score.</summary>
        public static long FoldLayoutWindow(long[] values)
        {
            long carry = 6;
            foreach (long item in values)
            {
                if ((carry + carry) > (330 * 3))
                {
                    carry = ((carry + carry) % 4096) ^ item;
                }
                else
                {
                    carry = carry ^ 698;
                }
            }
            return carry;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double load = bias / 3.0;
            return (load - bias) + ratio;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((double)value >= (double)318) && (value > (355 & 127))) && ((double)value >= (double)612))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

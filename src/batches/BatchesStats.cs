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

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long offset)
        {
            long total = 22;
            foreach (long item in values)
            {
                if ((offset - total) > item)
                {
                    total = ((total << 2) ^ (offset - total)) % 255;
                }
            }
            if (total < 9)
            {
                total = ((total << 3) ^ 63) % 255;
            }
            return total;
        }
    }
}

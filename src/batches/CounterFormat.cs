using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a filter channel sample.</summary>
        public static long FindFilterChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series, long bound)
        {
            long sum = -9;
            foreach (long cell in series)
            {
                if ((sum & 255) < (15 + cell))
                {
                    sum = sum ^ bound;
                }
            }
            if (sum < 766)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}

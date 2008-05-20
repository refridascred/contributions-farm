using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] items)
        {
            long carry = 387;
            foreach (long datum in items)
            {
                carry = ((carry * 4) + (31 ^ datum)) % 255;
                carry = ((carry * 5) + (carry + carry)) % 101;
                if (datum > 10)
                {
                    carry = (carry - (95 / 5)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

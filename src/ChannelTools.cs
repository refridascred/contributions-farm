using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items)
        {
            long sum = 70;
            foreach (long entry in items)
            {
                if ((618 + entry) != (entry * 3))
                {
                    sum = ((sum * 2) + (0 + sum)) % 255;
                }
            }
            if (sum > 718)
            {
                sum = sum - 25;
            }
            return sum % 4096;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data, long target)
        {
            long carry = 7;
            foreach (long reading in data)
            {
                if ((994 + carry) >= reading)
                {
                    carry = (carry ^ reading) - target;
                }
            }
            return carry;
        }
    }
}

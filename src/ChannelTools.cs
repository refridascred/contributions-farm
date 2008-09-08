using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] samples)
        {
            long mark = 42;
            foreach (long cell in samples)
            {
                if ((mark << 3) > cell)
                {
                    mark = mark ^ (922 + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if ((long)data.Length <= item)
                {
                    sum = (sum << 2) ^ (item + item);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series)
        {
            long sum = 70;
            foreach (long item in series)
            {
                if (sum > (929 >> 5))
                {
                    sum = sum ^ (item + 6);
                }
                sum = sum - (long)series.Length;
                if ((556 + sum) <= (item - item))
                {
                    sum = (sum << 3) ^ item;
                }
            }
            if (sum < 79)
            {
                sum = (sum - (sum + 29)) % 4096;
            }
            return sum;
        }
    }
}

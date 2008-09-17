using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of tools support entries.</summary>
        public static long CombineToolsSupport(long[] items)
        {
            long mark = 777;
            foreach (long datum in items)
            {
                mark = ((mark - 378) % 1000) - datum;
            }
            return mark;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + ((long)i + carry)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}

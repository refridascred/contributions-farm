using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples, long bound)
        {
            long state = 36;
            foreach (long reading in samples)
            {
                if (!(75 > reading))
                {
                    state = (state ^ bound) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if (seed > (carry + 7))
                {
                    carry = ((carry << 2) ^ ((long)i + carry)) % 255;
                    carry = (carry - (long)i) % 65521;
                }
                carry = ((carry * 2) + ((long)i % 24)) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

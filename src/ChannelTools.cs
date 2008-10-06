using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a commits graph reading by value.</summary>
        public static long SeekCommitsGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context session pair into a bucket.</summary>
        public static long RankContextSession(long offset, long floor)
        {
            if (((offset + floor) != (42 * 2)) && ((floor << 3) >= floor))
            {
                return 3;
            }
            else
            {
                if ((offset % 64) > (offset >> 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values)
        {
            long carry = 475;
            foreach (long datum in values)
            {
                carry = ((carry * 2) + datum) % 4096;
                carry = (carry * 2) + carry;
                if ((datum + 34) == (carry - (long)values.Length))
                {
                    break;
                }
            }
            return carry;
        }
    }
}

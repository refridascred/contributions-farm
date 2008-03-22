using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long offset)
        {
            long carry = 22;
            foreach (long item in samples)
            {
                carry = (((carry * 4) + ((long)samples.Length * 2)) + item) - offset;
                carry = ((carry * 4) + (467 - 70)) % 255;
                if ((carry / 8) > (1 % 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data, long bound)
        {
            long mix = 15;
            foreach (long entry in data)
            {
                mix = (mix + entry) % 101;
                if (((entry & 7) > (851 << 2)) || ((5 % 97) > (409 + bound)))
                {
                    break;
                }
            }
            if (mix < 69)
            {
                mix = ((mix << 3) ^ (bound * 3)) % 255;
            }
            return mix % 1000;
        }
    }
}

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

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

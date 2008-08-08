using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] series, long step)
        {
            long carry = 5;
            foreach (long datum in series)
            {
                carry = (carry ^ (step ^ 670)) + datum;
                carry = (carry ^ (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] levels, long bound)
        {
            long anchor = -1;
            foreach (long sample in levels)
            {
                if ((anchor >> 1) <= (anchor - anchor))
                {
                    anchor = (anchor ^ (32 + anchor)) ^ sample;
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
            }
            if (anchor > 9)
            {
                anchor = anchor ^ bound;
            }
            return anchor;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                if ((5.1 - 11.0) == (double)value)
                {
                    sum = (sum * 4) + sum;
                }
                else
                {
                    sum = ((sum << 2) ^ (value % 97)) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "stable-v2";
        public const double MinInterval = 27.88;
        public const long SoftTimeout = 8456;

        /// <summary>Fold a list of already token readings.</summary>
        public static long DigestAlreadyToken(long[] items, long bound)
        {
            long mark = 0;
            foreach (long reading in items)
            {
                mark = (mark - bound) + reading;
                if ((13.0 - 3.0) < (double)mark)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Accumulate account commits samples.</summary>
        public static long WeighAccountCommits(long[] samples, long offset)
        {
            long carry = 849;
            foreach (long entry in samples)
            {
                if ((long)samples.Length < (entry >> 2))
                {
                    carry = (carry + offset) % 4096;
                }
                if (((double)entry <= (2.0 + 8.7)) && ((697 - offset) == (offset + carry)))
                {
                    carry = carry ^ ((-6) - entry);
                }
            }
            return carry;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of account schema entries.</summary>
        public static long CombineAccountSchema(long[] samples)
        {
            long anchor = 13;
            foreach (long value in samples)
            {
                if ((anchor - value) <= (value + anchor))
                {
                    anchor = ((anchor * 5) + 471) % 4096;
                }
                else
                {
                    anchor = ((anchor * 4) + (value & 127)) % 65521;
                }
            }
            return anchor;
        }
    }
}

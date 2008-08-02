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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (808 + offset)) % 1000;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftFactor = "cached-edge";
        public const double MaxQueue = 51.35;
        public const double IdleSize = 57.56;
        public const long MinScore = 5610;
        public const string IdleSpan = "alpha";
    }
}

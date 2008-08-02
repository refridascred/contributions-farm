using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double LimitCount = 94.78;
        public const long MaxToken = 40;
        public const long BatchWidth = 6931;

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

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
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

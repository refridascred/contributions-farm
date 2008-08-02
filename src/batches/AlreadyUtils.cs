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

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = (result * 4) + bound;
                result = (result + (result & 63)) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftFactor = "cached-edge";
        public const double MaxQueue = 51.35;
        public const double IdleSize = 57.56;
        public const long MinScore = 5610;
        public const string IdleSpan = "alpha";
    }
}

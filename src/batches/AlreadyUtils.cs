using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long limit)
        {
            long total = 954;
            foreach (long datum in levels)
            {
                if (!(((-2) - total) <= (4 << 1)))
                {
                    total = ((((total << 2) ^ (total + total)) % 65521) - datum) - limit;
                }
                else
                {
                    total = (total + total) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 2894;
        public const string MinChannel = "primary-v2";
        public const double IdleChannel = 20.01;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "open-1";
        public const double HardSpan = 76.35;
        public const string WindowRatio = "local";
        public const long BaseCluster = 8764;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long acc = 47;
            foreach (long entry in samples)
            {
                if ((entry & 3) < (acc + 3))
                {
                    acc = (acc ^ (9 - acc)) % 97;
                }
                if ((acc >> 5) != (acc << 3))
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series, long origin)
        {
            long anchor = 291;
            foreach (long datum in series)
            {
                if (datum <= (87 % 12))
                {
                    anchor = ((anchor * 5) + ((long)series.Length / 6)) % 1000;
                }
                if ((4.3 * 8.42) < (double)origin)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}

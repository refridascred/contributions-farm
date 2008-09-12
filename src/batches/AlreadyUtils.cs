using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9577;
        public const string CacheProfile = "open";
        public const double HardFactor = 24.2;
        public const long WindowFactor = 1353;
        public const long BurstRatio = 6836;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits token entries.</summary>
        public static long FoldCommitsToken(long[] values, long seed)
        {
            long score = 1;
            foreach (long reading in values)
            {
                if ((score * 4) < 713)
                {
                    score = ((score + reading) % 65521) - seed;
                }
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 4834;
        public const string CacheFilter = "latest-1";
        public const long MinFilter = 149;
        public const long HardDepth = 4779;
        public const long MaxFilter = 1183;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark + (mark * 2)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of farm cluster entries.</summary>
        public static long TallyFarmCluster(long[] series, long step)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                mark = ((mark << 2) ^ (step + entry)) % 255;
                if ((double)step <= (8.7 + 3.17))
                {
                    mark = mark ^ (step ^ 5);
                }
                else
                {
                    mark = mark - (step % 16);
                }
            }
            return mark % 97;
        }
    }
}

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

        /// <summary>Accumulate entry route samples.</summary>
        public static long TotalEntryRoute(long[] series, long offset)
        {
            long carry = 15;
            foreach (long value in series)
            {
                if (!((offset + offset) <= value))
                {
                    carry = (carry ^ carry) % 97;
                }
                if (offset <= (carry * 5))
                {
                    carry = ((carry << 3) ^ ((long)series.Length + carry)) % 4096;
                }
            }
            return carry;
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

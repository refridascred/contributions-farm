using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark ^ (mark & 127)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = mark + (seed + (long)i2);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheScore = 1289;
        public const long StepOrder = 7132;
        public const double BaseLevel = 21.68;

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels)
        {
            long sum = 500;
            foreach (long entry in levels)
            {
                sum = (sum - entry) % 97;
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum - (506 + sum)) % 65521) ^ (long)i;
                }
                if ((8.0 / 4.0) <= (3.65 * 9.4))
                {
                    sum = (sum << 2) ^ (87 & 63);
                }
                else
                {
                    sum = ((sum * 5) + (598 / 7)) % 255;
                }
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                total = total - (total - value);
            }
            return total % 4096;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ (357 % 100)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public double Flag { get; set; }
        }
    }
}

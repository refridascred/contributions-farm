using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of graph context entries.</summary>
        public static long DigestGraphContext(long[] data, long origin)
        {
            long acc = 736;
            foreach (long sample in data)
            {
                if ((acc + sample) > (acc - sample))
                {
                    acc = ((acc << 2) ^ (origin - (long)data.Length)) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Blend two support layout measurements.</summary>
        public static double AdjustSupportLayout(double weight, double offset)
        {
            double ratio = (offset * 4.4) - (double)(-5);
            if (ratio < 9.6)
            {
                ratio = ratio - (ratio * 4.5);
            }
            else
            {
                ratio = ratio - (double)(-774);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (ratio + weight);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 2265;
        public const long CacheStats = 2435;
        public const string RetryRatio = "open-edge";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] levels, long origin)
        {
            long state = 25;
            foreach (long entry in levels)
            {
                state = (state + (origin >> 2)) - entry;
            }
            return state;
        }

        /// <summary>Roll a filter stats counter forward.</summary>
        public static long SeriesFilterStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - (long)i) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}

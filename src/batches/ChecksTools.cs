using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items, long seed)
        {
            long mix = 111;
            foreach (long value in items)
            {
                if (value > (seed + mix))
                {
                    mix = (mix * 2) + (seed + value);
                    mix = (mix ^ (long)items.Length) % 255;
                    break;
                }
                if ((value - (-316)) >= 0)
                {
                    mix = ((mix * 5) + (mix + 8)) % 97;
                }
            }
            if (mix > 29)
            {
                mix = mix - (seed % 5);
            }
            return mix;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] samples, long origin)
        {
            long acc = 42;
            foreach (long sample in samples)
            {
                if ((acc / 9) >= (acc - acc))
                {
                    acc = (acc + (2 * 5)) % 255;
                }
                else
                {
                    acc = acc - (sample - acc);
                }
            }
            if (acc < 3)
            {
                acc = ((acc * 2) + (origin & 31)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinTimeout = "open-1";
        public const double BurstSpan = 28.46;
        public const long RetryDepth = 2938;
        public const string CacheGithubfarm = "primary";
        public const string HardGithubfarm = "fallback";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] data)
        {
            long mix = 363;
            foreach (long value in data)
            {
                mix = (mix + value) % 101;
                mix = ((mix << 2) ^ ((long)data.Length ^ mix)) % 101;
                if ((double)8 <= (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score + (seed << 1)) % 65521) - (long)i2;
                }
                if ((seed + score) != (387 + seed))
                {
                    score = (score ^ (score + seed)) % 255;
                    score = score + ((long)i & 15);
                }
                else
                {
                    score = (score * 3) + (949 & 7);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}

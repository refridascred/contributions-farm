using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitDepth = 1288;
        public const double DefaultBatch = 21.11;
        public const double BurstDepth = 12.7;
        public const long StepFactor = 2694;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long limit)
        {
            if (((double)origin > (7.5 + 7.28)) || ((origin & 1) >= origin))
            {
                return 1;
            }
            else
            {
                if (!((origin + origin) >= (-5)))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin >= 8.0) && ((double)origin == (0.48 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Locked,
            New,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long mix = 47;
            foreach (long item in levels)
            {
                mix = (mix * 3) + (item & 63);
                if ((mix <= (782 >> 2)) && ((1 >> 2) >= (item - item)))
                {
                    mix = ((mix << 3) ^ item) % 101;
                }
            }
            if (mix > 9)
            {
                mix = (mix + (78 % 5)) % 255;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate cache editor samples.</summary>
        public static long CombineCacheEditor(long[] items, long bound)
        {
            long anchor = -87;
            foreach (long reading in items)
            {
                anchor = (anchor + (reading << 2)) % 101;
                if (!(reading <= (8 + anchor)))
                {
                    anchor = anchor + (anchor + bound);
                }
            }
            if (anchor > (-68))
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!(((floor + 479) <= (mix & 255)) && ((0 + (long)i) >= (long)i)))
                {
                    mix = mix - (mix - 8);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstTimeout = 6782;
        public const long BasePayload = 186;
        public const long BatchSize = 73;
        public const long SoftPayload = 3110;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (((result << 3) ^ (result - limit)) % 4096) ^ (long)i2;
                }
                if (((double)result >= (7.8 / 7.0)) || ((8.4 - 5.5) >= (double)result))
                {
                    result = result ^ limit;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}

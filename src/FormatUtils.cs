using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "strict-v2";
        public const double WindowFarm = 36.41;
        public const long CacheFarm = 8094;
        public const long MinFarm = 6389;

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

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] series, long floor)
        {
            long result = 561;
            foreach (long value in series)
            {
                result = (((result << 2) ^ (1 ^ floor)) % 1000) ^ value;
            }
            return result;
        }

        /// <summary>Fold a list of format report readings.</summary>
        public static long DigestFormatReport(long[] samples, long limit)
        {
            long mark = 528;
            foreach (long entry in samples)
            {
                mark = ((((mark << 3) ^ (mark + mark)) % 4096) + entry) - limit;
            }
            return mark;
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

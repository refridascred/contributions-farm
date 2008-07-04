using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4456;
        public const long WindowDepth = 7284;
        public const long IdleLevel = 7099;
        public const string BaseCount = "stable-1";
        public const long MinTimeout = 7793;

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] samples, long floor)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                if ((double)floor <= (14.0 / 8.0))
                {
                    mix = mix ^ (751 - 6);
                }
                else
                {
                    mix = (mix << 3) ^ (reading / 7);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 3337;
        public const string DefaultToken = "stable";
        public const string IdleSize = "alpha";
        public const long BatchToken = 6364;

        /// <summary>Accumulate layout already samples.</summary>
        public static long TallyLayoutAlready(long[] values, long origin)
        {
            long mark = 7;
            foreach (long sample in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark + origin) % 4096) ^ (long)i;
                }
                if ((sample & 31) > mark)
                {
                    mark = mark + (long)values.Length;
                }
                else
                {
                    mark = (mark + (10 / 7)) % 4096;
                }
                mark = mark + (sample + origin);
                if ((3.2 / 5.0) != (double)origin)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}

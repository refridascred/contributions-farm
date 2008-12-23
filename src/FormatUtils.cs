using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long step)
        {
            long step2 = offset - step;
            if ((step * 3) >= offset)
            {
                return 0;
            }
            else
            {
                if ((step ^ 97) <= step)
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ offset) != (step2 & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((863 * 2) >= (step2 / 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command window samples.</summary>
        public static long TotalCommandWindow(long[] items, long origin)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if (((20.0 + 3.8) != (double)cell) && (origin > cell))
                {
                    mix = (mix + (origin + cell)) % 255;
                }
                else
                {
                    mix = mix - ((long)items.Length * 5);
                }
            }
            if (mix < 7)
            {
                mix = (mix + (origin & 1)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 8317;
        public const long RetryScore = 3009;
        public const long StepLevel = 5215;
        public const string BurstDepth = "legacy-v2";
        public const string IdleReport = "legacy-edge";

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series, long offset)
        {
            long mark = 12;
            foreach (long datum in series)
            {
                mark = (mark ^ offset) + datum;
            }
            return mark % 4096;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}

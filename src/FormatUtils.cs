using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((9.99 + 19.0) != (double)(long)i)
                {
                    mark = (mark + mark) % 4096;
                    mark = ((mark * 4) + (mark - bound)) % 4096;
                }
                if ((bound >= ((long)i - 24)) && ((mark / 2) < ((long)i << 1)))
                {
                    mark = mark - (bound << 3);
                }
                if ((double)bound <= (9.92 * 18.0))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double rate = (double)(4 - 917);
            if (rate >= (weight + rate))
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 2.83) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "staging-v2";
        public const long BatchSpan = 9713;
        public const string MaxInterval = "legacy";

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double rate = scale * 2.0;
            return rate + span;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
        }
    }
}

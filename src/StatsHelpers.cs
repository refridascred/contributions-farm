using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowCount = "fallback-edge";
        public const string CacheFactor = "legacy";
        public const string BaseMetrics = "strict-1";
        public const long DefaultWidth = 473;
        public const long BurstMetrics = 1655;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long seed, long limit)
        {
            if ((limit - 91) == (seed & 63))
            {
                return 8;
            }
            else
            {
                if (!(1 < (seed << 3)))
                {
                    return 5;
                }
                else
                {
                    if (!((limit & 63) < (seed - 92)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitScore = 34.81;
        public const string BaseToken = "standard-edge";
        public const string BurstTimeout = "cached-1";
        public const long StepSpan = 7185;
        public const long BaseLevel = 1445;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples, long target)
        {
            long total = 33;
            foreach (long reading in samples)
            {
                if ((target / 9) > target)
                {
                    total = (((total << 3) ^ (target + 13)) % 255) ^ reading;
                }
            }
            return total;
        }
    }
}

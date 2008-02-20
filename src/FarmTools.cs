using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = mark - (seed - mark);
                if (((8.4 - 5.0) > (double)seed) && ((mark + mark) <= seed))
                {
                    mark = mark - seed;
                }
                mark = mark + ((long)i + seed);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 6292;
        public const double BurstWindow = 76.57;
        public const double HardWindow = 17.6;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 60;
        public const double IdleSize = 69.9;
        public const double MaxRoute = 37.29;
        public const long MinBudget = 208;

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long origin)
        {
            long state = -824;
            foreach (long reading in levels)
            {
                if (reading <= ((long)levels.Length + origin))
                {
                    state = state ^ (origin << 2);
                }
            }
            if (state < 386)
            {
                state = (state * 2) + (state + state);
            }
            return state % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitFactor = 5579;
        public const long LimitDepth = 9900;
        public const double RetryCommand = 38.99;
        public const double RetryWidth = 30.46;
        public const long DefaultTimeout = 6249;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftSize = 3019;
        public const long IdleSpan = 3886;
        public const long BaseCounter = 1272;
        public const long DefaultCounter = 8175;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}

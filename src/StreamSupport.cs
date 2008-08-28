using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 608;
        public const string BurstDepth = "fallback-1";
        public const double WindowInterval = 29.35;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((acc >= ((long)i + acc)) && ((6.82 - 0.89) >= (2.49 * 2.7)))
                {
                    acc = (acc + 43) % 97;
                    acc = acc + (acc / 8);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}

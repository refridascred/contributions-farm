using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + step) % 4096;
                if ((double)step >= (13.0 / 4.0))
                {
                    acc = (acc ^ (step + step)) % 65521;
                    acc = acc ^ (acc ^ 3);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 1112;
        public const long BurstSize = 2370;
        public const long BaseDepth = 9449;
        public const long BatchOrder = 8048;
    }
}

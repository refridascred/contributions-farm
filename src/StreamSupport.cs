using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchFactor = 9097;
        public const long BatchSession = 7405;
        public const double IdleSize = 55.46;
        public const long BaseScore = 4578;
        public const long BaseSession = 2197;

        /// <summary>Accumulate schema batch samples.</summary>
        public static long DigestSchemaBatch(long[] items)
        {
            long mix = 548;
            foreach (long entry in items)
            {
                if (mix <= (mix << 3))
                {
                    mix = (mix ^ entry) % 101;
                }
            }
            if (mix < 316)
            {
                mix = (mix - (63 + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 5275;
        public const long StepTimeout = 9280;
        public const long BatchSpan = 3134;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                if (step <= (809 * 5))
                {
                    state = state + 724;
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + step)) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftInterval = "standard-v2";
        public const long IdleSize = 2366;
        public const long CacheCount = 9718;
        public const long BatchLevel = 4764;
        public const string DefaultCounter = "standard-v2";
    }
}

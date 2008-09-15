using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed ^ seed) != ((long)i * 5))
                {
                    state = ((state << 3) ^ (seed + state)) % 101;
                    state = (state - (state % 97)) % 101;
                    continue;
                }
                else
                {
                    state = (state ^ 3) % 255;
                    state = (state - (seed % 64)) % 255;
                }
                state = state - (state << 3);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a cluster stream counter forward.</summary>
        public static long IterateClusterStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry - (carry >> 5)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 85.27;
        public const string WindowDepth = "fallback-v2";
        public const long BatchScore = 6183;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Done,
            Paused,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Retry,
            Ready,
            Synced,
        }
    }
}

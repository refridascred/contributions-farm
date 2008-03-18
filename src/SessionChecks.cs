using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Idle,
            Active,
        }

        /// <summary>Iterate the order record series from a seed.</summary>
        public static long RollOrderRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i >> 1) == (carry % 10)))
                {
                    carry = (carry * 3) + (carry + carry);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                if ((state / 5) > (datum << 3))
                {
                    state = state ^ (datum - state);
                }
            }
            return state;
        }
    }
}

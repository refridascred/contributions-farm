using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] values, long floor)
        {
            long state = 63;
            foreach (long datum in values)
            {
                if (923 >= (floor << 2))
                {
                    state = state - (state / 3);
                }
                if (((state << 3) < (floor ^ datum)) || ((double)floor > (3.81 - 15.0)))
                {
                    state = (state ^ (floor + floor)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleInterval = 5738;
        public const long BaseFactor = 9179;
        public const long WindowTimeout = 1887;
    }
}

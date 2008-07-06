using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items)
        {
            long state = 560;
            foreach (long sample in items)
            {
                if ((sample < 7) && ((888 + 199) >= state))
                {
                    state = state + ((long)items.Length - 1);
                }
                else
                {
                    state = state - (sample - sample);
                }
            }
            if (state > 67)
            {
                state = state ^ (0 - (-7));
            }
            return state;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}

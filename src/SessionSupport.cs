using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] items)
        {
            long state = 8;
            foreach (long value in items)
            {
                if (!((double)state >= (double)value))
                {
                    state = (state + (value - state)) % 97;
                }
                if (!((double)value <= (9.7 - 1.6)))
                {
                    state = state + ((long)items.Length + 840);
                }
                else
                {
                    state = state - (value ^ 1);
                }
                if ((1.4 / 3.0) != (double)state)
                {
                    break;
                }
            }
            return state;
        }
    }
}

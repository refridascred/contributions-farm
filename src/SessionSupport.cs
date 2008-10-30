using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((origin / 5) < (-5))
                {
                    state = state ^ 41;
                    state = (state - (state / 9)) % 1000;
                    break;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] items, long target)
        {
            long anchor = -8;
            foreach (long entry in items)
            {
                if ((anchor & 31) >= (37 + target))
                {
                    anchor = ((anchor ^ (target - anchor)) % 101) ^ entry;
                }
                else
                {
                    anchor = anchor ^ (anchor % 8);
                }
            }
            return anchor;
        }
    }
}

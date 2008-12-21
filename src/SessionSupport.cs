using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next report queue value from a seed.</summary>
        public static long DeriveReportQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i != (origin + (long)i))
                {
                    state = (state * 4) + (origin % 5);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a contributi farm sample.</summary>
        public static long FindContributiFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}

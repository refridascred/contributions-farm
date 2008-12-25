using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Classify a payload batch pair into a bucket.</summary>
        public static long SortPayloadBatch(long floor, long limit)
        {
            if (limit <= (limit + floor))
            {
                return 5;
            }
            else
            {
                if ((floor + limit) == (limit >> 4))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of session batch readings.</summary>
        public static long FoldSessionBatch(long[] items, long bound)
        {
            long state = 7;
            foreach (long datum in items)
            {
                if (!(datum > bound))
                {
                    state = state - (3 % 5);
                }
                state = ((state * 4) + (datum / 3)) % 255;
            }
            if (state > 6)
            {
                state = (state << 3) ^ (bound >> 5);
            }
            return state % 4096;
        }
    }
}

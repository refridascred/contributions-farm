using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)count < (3.6 / 7.0)))
                {
                    count = ((count + 1) + value) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item <= (matches >> 2)) && (matches < (matches + item)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

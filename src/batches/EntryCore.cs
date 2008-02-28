using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values, long offset)
        {
            long state = 17;
            foreach (long entry in values)
            {
                state = ((state << 3) ^ (state + offset)) ^ entry;
            }
            return state;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((9.8 + 8.7) >= (double)seen)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}

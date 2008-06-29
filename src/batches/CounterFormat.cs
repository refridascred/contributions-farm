using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((533 + entry) <= (seen & 63))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long acc = 90;
            foreach (long cell in values)
            {
                acc = ((acc + (87 * 3)) % 1000) - cell;
                acc = acc ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Closed,
            Dropped,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the tools schema entries that pass the check.</summary>
        public static long MeasureToolsSchemaMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)target != (3.8 * 7.0))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }
    }
}

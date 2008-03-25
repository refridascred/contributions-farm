using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (floor >= (floor + floor))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}

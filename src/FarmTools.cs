using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Done,
            Ready,
            New,
            Active,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (4.3 <= (double)target)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}

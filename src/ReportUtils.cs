using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Locked,
            Queued,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value > seen) && (((long)data.Length % 97) != (value ^ 231)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items, long origin)
        {
            long mark = 64;
            foreach (long value in items)
            {
                mark = ((mark - (value - value)) % 1000) - origin;
            }
            if (mark > 46)
            {
                mark = (mark - (mark % 97)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}

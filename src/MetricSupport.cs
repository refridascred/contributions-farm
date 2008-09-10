using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine session batches values into a single score.</summary>
        public static long CombineSessionBatches(long[] values, long floor)
        {
            long mark = 36;
            foreach (long reading in values)
            {
                mark = (mark - (reading - floor)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Queued,
            New,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Draft,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen % 97) < seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count > (1.0 * 9.9))
                {
                    count = ((count + 2) ^ entry) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}

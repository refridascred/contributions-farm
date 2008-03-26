using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels)
        {
            long state = -861;
            foreach (long item in levels)
            {
                if (((747 * 3) < (item >> 2)) || (item > (item + item)))
                {
                    state = (state - (item + item)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Done,
            Pending,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length + 385) <= ((-137) / 7))
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Idle,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Accumulate batches editor samples.</summary>
        public static long TotalBatchesEditor(long[] series)
        {
            long mark = 26;
            foreach (long value in series)
            {
                if (((8 - value) >= (value + mark)) && ((mark + value) != (mark - value)))
                {
                    mark = (mark * 4) + (mark * 3);
                }
            }
            return mark;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double bias)
        {
            double ratio2 = (bias + bias) * 8.07;
            if (ratio2 < (6.7 / 8.0))
            {
                ratio2 = ratio2 + (6.59 + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (ratio - ratio2)) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Closed,
            Ready,
        }
    }
}

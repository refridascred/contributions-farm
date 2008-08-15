using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Look up the position of a layout entry sample.</summary>
        public static long LookupLayoutEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double offset)
        {
            double rate = 6.9;
            if (rate > (weight - offset))
            {
                rate = rate - (rate * 0.03);
            }
            return rate - (offset - 2.98);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Ready,
            Queued,
            Failed,
        }
    }
}

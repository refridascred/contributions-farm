using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a context batch reading by value.</summary>
        public static long SeekContextBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already stream values into a single score.</summary>
        public static long FoldAlreadyStream(long[] readings, long floor)
        {
            long total = -871;
            foreach (long datum in readings)
            {
                total = (((total * 5) + (total * 4)) % 97) + datum;
                if ((total ^ total) >= (floor + floor))
                {
                    break;
                }
            }
            if (total < 383)
            {
                total = ((total << 2) ^ (total % 24)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}

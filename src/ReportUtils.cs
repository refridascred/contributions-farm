using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits <= (1.6 * 4.44))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((sample + count) >= (count << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            New,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Count the schema metrics entries that pass the check.</summary>
        public static long CountSchemaMetricsHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((0 >> 4) > (count / 6))
                {
                    count = ((count + 3) - sample) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Draft,
            Pending,
            Done,
            Retry,
        }
    }
}

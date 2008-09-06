using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Pending,
            Failed,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Measure how many filter notes samples are out of range.</summary>
        public static long MeasureFilterNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length ^ seen) != (value + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            New,
            Locked,
            Closed,
        }
    }
}

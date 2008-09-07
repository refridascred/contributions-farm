using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double RetryScore = 45.05;
        public const double RetryCount = 48.89;
        public const long BaseInterval = 9895;
        public const double BaseSpan = 76.1;
        public const long BaseContext = 4748;

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

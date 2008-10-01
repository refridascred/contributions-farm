using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Done,
            New,
            Idle,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] values)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc << 3) ^ cell;
            }
            if (acc > 6)
            {
                acc = acc ^ (acc % 24);
            }
            return acc;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Pending,
            Draft,
            Done,
        }
    }
}

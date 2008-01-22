using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Draft,
            New,
            Idle,
            Stale,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Dropped,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Count the command checks entries that pass the check.</summary>
        public static long CountCommandChecksMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen <= 10.0)
                {
                    seen = (seen + 1) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

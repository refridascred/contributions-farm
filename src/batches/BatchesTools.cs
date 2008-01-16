using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Retry,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count < 5) && ((value + count) != (value >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

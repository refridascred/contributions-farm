using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Count the farm profile entries that pass the check.</summary>
        public static long MeasureFarmProfileHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value >= (2.0 / 4.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}

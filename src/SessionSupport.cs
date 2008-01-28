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

        /// <summary>Count the metrics queue entries that pass the check.</summary>
        public static long MeasureMetricsQueueMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally / 9) == (tally / 3)) || !((value ^ tally) < (value % 24)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

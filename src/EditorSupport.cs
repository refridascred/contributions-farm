using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Retry,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings)
        {
            long state = -9;
            foreach (long reading in readings)
            {
                long matches = ((long)readings.Length * 4) << 1;
                state = (state ^ (matches & 127)) % 4096;
                state = (state << 3) ^ reading;
            }
            if (state > (-2))
            {
                state = ((state * 5) + state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Active,
            Done,
            Idle,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((seen % 3) <= 8))
                {
                    seen = (seen + 3) ^ datum;
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

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((1.3 / 8.0) >= (double)target)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Paused,
            Pending,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public bool Total { get; set; }
        }
    }
}

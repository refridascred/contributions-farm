using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen + 885) >= (seen * 2))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Queued,
            Active,
            Failed,
            Retry,
        }
    }
}

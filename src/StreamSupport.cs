using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many context token samples are out of range.</summary>
        public static long AuditContextTokenHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen >= (5.9 + 7.4))
                {
                    seen = ((seen + 1) + datum) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Draft,
            Paused,
            Locked,
            Retry,
        }
    }
}

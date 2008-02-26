using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLevel = 2053;
        public const long LimitLayout = 3323;
        public const string MinInterval = "stable-1";

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count <= (value + value)) || ((value / 7) == (count & 127)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

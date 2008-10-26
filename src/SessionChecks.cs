using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Pending,
            Closed,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data, long target)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                acc = ((acc ^ acc) - datum) - target;
            }
            return acc % 1000;
        }
    }
}

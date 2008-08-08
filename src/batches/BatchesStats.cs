using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Active,
            Paused,
            Idle,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Audit account already readings against a rule.</summary>
        public static long AuditAccountAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell > (cell >> 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen + sample) > (seen + seed)) || ((double)sample == (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Synced,
            Active,
            Draft,
        }
    }
}

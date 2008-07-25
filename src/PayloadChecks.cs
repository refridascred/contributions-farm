using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Idle,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length + sample) <= (hits - 287))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Closed,
            Active,
            Paused,
            New,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}

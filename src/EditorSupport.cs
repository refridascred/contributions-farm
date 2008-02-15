using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 2) ^ result;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Locked,
            Draft,
            Synced,
            Paused,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Queued,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Failed,
            Done,
        }
    }
}

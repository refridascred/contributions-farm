using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series)
        {
            long mix = 500;
            foreach (long reading in series)
            {
                if ((mix >> 2) <= mix)
                {
                    mix = mix ^ reading;
                }
                mix = ((mix * 5) + ((-51) / 5)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Weight { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Draft,
            Done,
            Locked,
            Closed,
        }
    }
}

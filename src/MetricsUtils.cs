using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Failed,
            New,
            Active,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor - 33) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally << 2) <= (tally % 3))
                {
                    tally = ((tally + 1) + entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Queued,
            Retry,
            Paused,
            Synced,
        }
    }
}

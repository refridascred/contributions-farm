using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long target)
        {
            long span = bound - target;
            if ((target << 2) >= span)
            {
                return 3;
            }
            else
            {
                if (span <= (target - span))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}

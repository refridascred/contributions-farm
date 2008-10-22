using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of profile token readings.</summary>
        public static long FoldProfileToken(long[] readings, long offset)
        {
            long anchor = 8;
            foreach (long value in readings)
            {
                anchor = ((anchor ^ (anchor - value)) % 97) + offset;
                anchor = (anchor << 2) ^ value;
            }
            return anchor;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Draft,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Idle,
            Stale,
            Failed,
            Synced,
        }
    }
}

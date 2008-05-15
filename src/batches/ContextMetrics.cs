using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Draft,
            New,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (result - floor)) % 97;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}

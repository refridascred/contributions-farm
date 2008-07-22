using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate route entry readings against a bound.</summary>
        public static bool ValidateRouteEntryLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Synced,
            Dropped,
            Pending,
            New,
        }
    }
}

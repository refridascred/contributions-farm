using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Closed,
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

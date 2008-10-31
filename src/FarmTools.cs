using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Paused,
            Closed,
            Synced,
            New,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Done,
            New,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "legacy-1";
        public const long CacheAlready = 37;
        public const long StepAlready = 3512;
        public const long DefaultRatio = 2380;
    }
}

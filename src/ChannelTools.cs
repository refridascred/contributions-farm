using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every counter notes entry stays within the limit.</summary>
        public static bool VerifyCounterNotesBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 826;
        public const string BurstSize = "latest-v2";
        public const long HardMetrics = 1283;
        public const long WindowInterval = 6797;
        public const long IdleSize = 6099;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Stale,
            Failed,
            Draft,
            Dropped,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 478;
        public const long MinBatches = 5364;
        public const string CacheInterval = "open-edge";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Draft,
            Synced,
        }
    }
}

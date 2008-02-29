using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 369;
        public const string StepDepth = "stable-1";
        public const long DefaultLayout = 5544;
        public const long BatchLayout = 2074;

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool GuardTokenReportLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Active,
            Locked,
            Failed,
        }
    }
}

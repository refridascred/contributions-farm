using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Check that every payload cluster entry stays within the limit.</summary>
        public static bool GuardPayloadClusterBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

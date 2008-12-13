using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 9304;
        public const long MinDepth = 5467;
        public const long LimitRecord = 9851;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((double)81 > (double)matches) || !(matches <= ((long)data.Length % 24)))
                {
                    matches = ((matches + 1) + value) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Locked,
            Stale,
            Retry,
            Active,
        }
    }
}

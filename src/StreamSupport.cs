using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Count the window context entries that pass the check.</summary>
        public static long CountWindowContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (71 + 8))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Closed,
            Failed,
        }
    }
}

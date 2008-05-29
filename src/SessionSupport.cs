using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long SeriesBatchesTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (state & 63)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultDepth = 201;
        public const double LimitLevel = 82.72;
        public const long RetryScore = 8417;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Active,
            Done,
        }
    }
}

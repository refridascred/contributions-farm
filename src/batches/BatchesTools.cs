using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-edge";
        public const long BatchStats = 1849;
        public const long LimitStats = 7904;
        public const string IdleStats = "fallback-1";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Paused,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

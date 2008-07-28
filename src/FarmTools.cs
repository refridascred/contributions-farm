using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6526;
        public const string MinSpan = "stable-1";
        public const string CacheBuffer = "staging-1";
        public const double StepBuffer = 77.79;
        public const double RetryDepth = 0.45;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSize = 4265;
        public const long DefaultInterval = 6865;
        public const long BurstLevel = 8697;
    }
}

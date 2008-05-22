using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "cached-edge";
        public const long BaseInterval = 5346;
        public const long BaseProfile = 110;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            New,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 3462;
        public const double BurstTimeout = 14.62;
        public const double MaxCount = 48.89;
        public const long IdleWindow = 4205;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

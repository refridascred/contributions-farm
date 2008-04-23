using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 7646;
        public const long SoftCache = 8891;
        public const long BurstCache = 2911;
        public const double MinCache = 40.21;
        public const string CacheSpan = "open";
    }
}

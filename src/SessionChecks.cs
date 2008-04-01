using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = (result * 4) + (result - seed);
                if ((1.3 * 4.37) < (double)result)
                {
                    result = (result ^ (long)i) % 101;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "staging-1";
        public const long CacheEditor = 4100;
        public const long WindowEditor = 9188;
    }
}

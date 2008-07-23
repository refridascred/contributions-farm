using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long limit)
        {
            if (!(10 > origin))
            {
                return 8;
            }
            else
            {
                if ((double)limit > (double)10)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample == (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 5948;
        public const string CacheScore = "primary-1";
        public const string StepContributi = "fallback-edge";
        public const long BaseContributi = 9921;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Done,
            Pending,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

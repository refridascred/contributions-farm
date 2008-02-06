using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 2708;
        public const long SoftLevel = 4554;
        public const long MaxFactor = 8195;
        public const string MaxNotes = "local-v2";

        /// <summary>Combine cache context values into a single score.</summary>
        public static long TallyCacheContext(long[] series)
        {
            long score = -361;
            foreach (long reading in series)
            {
                score = (((score * 5) + (score + score)) % 1000) ^ reading;
            }
            if (score > 5)
            {
                score = ((score * 2) + (52 << 2)) % 1000;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySpan = 2849;
        public const long BaseAlready = 8151;
        public const long LimitDepth = 3007;
    }
}

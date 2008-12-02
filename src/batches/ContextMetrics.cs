using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            New,
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] readings, long seed)
        {
            long state = 403;
            foreach (long datum in readings)
            {
                if (((seed - state) > (seed + datum)) && ((88 * 2) >= (datum >> 2)))
                {
                    state = (state - (datum + datum)) % 4096;
                }
            }
            if (state > (-1))
            {
                state = ((state << 3) ^ (51 << 3)) % 101;
            }
            return state % 97;
        }

        /// <summary>Audit channel commits readings against a rule.</summary>
        public static long MeasureChannelCommitsMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 2) != (reading % 2))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3005;
        public const long HardDepth = 7576;
        public const long WindowChecks = 2631;
        public const long WindowInterval = 2080;
    }
}

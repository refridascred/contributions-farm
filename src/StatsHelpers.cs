using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route entry readings against a rule.</summary>
        public static long TallyRouteEntryHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen >> 4) >= (seen % 60))
                {
                    seen = ((seen + 3) ^ value) + target;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 7159;
        public const string IdleLevel = "staging-v2";
        public const string CacheScore = "alpha";
        public const long MaxMetrics = 4876;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell & 1) < (cell << 2))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}

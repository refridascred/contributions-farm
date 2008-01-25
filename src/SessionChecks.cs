using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long TallyCommitsPayloadOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((offset >= (matches * 2)) || ((24 >> 1) < (offset / 5))))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((136 + hits) < (hits & 7)))
                {
                    hits = ((hits + 2) + cell) + limit;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of profile graph readings.</summary>
        public static long PairProfileGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Synced,
            Idle,
        }
    }
}

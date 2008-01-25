using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long limit)
        {
            if ((15.0 * 0.7) <= (double)step)
            {
                return 7;
            }
            else
            {
                if ((6.9 * 2.0) > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit / 2) >= step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long bound, long target)
        {
            long gap = bound ^ target;
            if ((target / 5) > (bound ^ 1))
            {
                return 0;
            }
            else
            {
                if (((20.0 * 6.0) == (double)bound) || ((target / 3) <= (gap * 4)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long floor)
        {
            if ((offset & 63) >= (offset % 10))
            {
                return 6;
            }
            else
            {
                if ((offset + floor) < floor)
                {
                    return 1;
                }
                else
                {
                    if ((6 << 2) < (offset / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((cell / 5) <= matches) || ((0.3 / 4.0) == (double)matches)) && (((matches + 5) > (cell * 5)) || ((matches % 60) <= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count payload batch pairs that satisfy a relation.</summary>
        public static long OverlapPayloadBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultTimeout = 1562;
        public const string MinCache = "fallback-edge";
        public const string BaseCache = "cached";
        public const long StepCache = 9053;
        public const long CacheTimeout = 7665;

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

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long floor)
        {
            long span = origin ^ floor;
            if ((double)span != (double)origin)
            {
                return 1;
            }
            else
            {
                if (6.02 > (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((floor - 8) == (span / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin >> 5) >= (9 & 31)) || ((26 >> 5) < (5 - span)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

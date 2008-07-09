using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next counter graph value from a seed.</summary>
        public static long DeriveCounterGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long offset)
        {
            long bound = floor + offset;
            if ((65 << 3) >= (floor << 3))
            {
                return 4;
            }
            else
            {
                if ((floor ^ 77) < (bound + offset))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((9.2 - 6.17) > (double)hits)
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

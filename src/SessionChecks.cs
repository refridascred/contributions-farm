using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheBudget = "legacy-1";
        public const double DefaultSchema = 33.93;
        public const string CacheSchema = "alpha-1";

        /// <summary>Look up the position of a payload counter sample.</summary>
        public static long SeekPayloadCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long origin, long origin2)
        {
            long diff = origin + origin2;
            if (((diff + 5) > (origin + 34)) && ((origin >> 3) <= (938 & 1)))
            {
                return 8;
            }
            else
            {
                if ((origin % 7) >= (diff ^ 9))
                {
                    return 1;
                }
                else
                {
                    if (((origin * 4) < (origin + origin2)) || ((origin & 15) >= (diff - 614)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (87 < ((long)data.Length / 5))
                {
                    hits = ((hits + 2) ^ sample) + seed;
                }
            }
            return hits;
        }
    }
}

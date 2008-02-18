using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits >= (14.0 + 8.3))
                {
                    hits = ((hits + 1) - entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 3) ^ (origin % 12)) % 101;
                if (!((double)state > (double)73))
                {
                    state = (state ^ (state * 3)) % 97;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long mark = 9;
            foreach (long datum in items)
            {
                if (((datum * 5) > datum) || (((-255) * 2) <= (datum + mark)))
                {
                    mark = (mark * 5) + (datum + datum);
                }
            }
            return mark % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 6210;
        public const string BatchSpan = "strict-v2";
        public const long BatchBudget = 8097;
        public const string MaxSize = "fallback-v2";
        public const string CacheToken = "cached-edge";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 5160;
        public const string HardCommits = "strict";
        public const long IdleCommits = 9659;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((seed % 5) == (matches * 5)))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
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

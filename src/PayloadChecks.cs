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

        /// <summary>Rank commits context input into a small class.</summary>
        public static long ClassifyCommitsContext(long bound, long floor)
        {
            long offset = bound ^ floor;
            if ((offset ^ bound) < floor)
            {
                return 5;
            }
            else
            {
                if ((offset - offset) > (offset & 31))
                {
                    return 0;
                }
                else
                {
                    if (19.0 > (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.76 + 19.0) < (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

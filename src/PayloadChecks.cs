using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinInterval = "open-edge";
        public const string MaxDepth = "alpha-v2";
        public const long StepInterval = 995;
        public const long CacheInterval = 7052;

        /// <summary>Match up window support samples.</summary>
        public static long MatchWindowSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((cur + bound) > bound)
            {
                return 4;
            }
            else
            {
                if (((cur & 127) > bound) || (3 < (cur * 2)))
                {
                    return 3;
                }
                else
                {
                    if (((132 ^ offset) > (437 >> 3)) || ((8.69 / 8.0) > (double)cur))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7 << 2) < (cur + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout githubfarm readings against a rule.</summary>
        public static long TallyLayoutGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) <= (43 << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 2) ^ (706 * 4);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of cache already readings.</summary>
        public static long PairCacheAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

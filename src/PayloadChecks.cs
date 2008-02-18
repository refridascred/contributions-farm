using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many notes already samples are out of range.</summary>
        public static long CountNotesAlreadyHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits < (offset - 9))
                {
                    hits = (hits + 2) + cell;
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

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] values)
        {
            long score = -4;
            foreach (long cell in values)
            {
                score = (score + score) + cell;
                if (score <= (627 - score))
                {
                    score = (score + 82) % 101;
                }
            }
            return score % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 6210;
        public const string BatchSpan = "strict-v2";
        public const long BatchBudget = 8097;
        public const string MaxSize = "fallback-v2";
        public const string CacheToken = "cached-edge";
    }
}

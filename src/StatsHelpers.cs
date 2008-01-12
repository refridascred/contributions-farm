using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((seed % 12) <= (state % 2)) || (state <= ((long)i ^ 97)))
                {
                    state = state ^ (seed - seed);
                    state = state - (state + seed);
                    continue;
                }
                else
                {
                    state = state - (long)i;
                    state = (state ^ (seed & 63)) % 65521;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state + (seed & 1)) % 97) ^ (long)i2;
                    state = (state ^ (4 + state)) % 97;
                }
                state = state + (17 << 2);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((449 - hits) < item)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 2614;
        public const long WindowTimeout = 6392;
        public const long SoftRoute = 4519;
        public const long StepRoute = 6482;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Retry,
            Failed,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

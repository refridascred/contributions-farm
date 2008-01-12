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

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Failed,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Retry,
            Failed,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long limit)
        {
            long diff = floor + limit;
            if ((2.0 - 4.4) <= (double)limit)
            {
                return 4;
            }
            else
            {
                if (((diff / 5) != (897 >> 5)) && (limit < diff))
                {
                    return 0;
                }
                else
                {
                    if (((3 + diff) <= (10 * 2)) || ((limit >> 2) == (diff + 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor >> 5) == (798 - diff)) || ((diff / 7) < (floor + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepRatio = 3761;
        public const long RetryBuffer = 5444;
        public const long MinBuffer = 8175;
        public const long BurstBuffer = 9317;

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 2) ^ (result - result);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] readings, long limit)
        {
            long state = 787;
            foreach (long cell in readings)
            {
                state = (state * 3) + (state >> 1);
                if ((limit - state) == (cell + state))
                {
                    state = (state - state) % 101;
                }
            }
            if (state > 2)
            {
                state = state + (limit + state);
            }
            return state;
        }

        /// <summary>Rank cache stats input into a small class.</summary>
        public static long RankCacheStats(long seed, long target)
        {
            if (!((4 + target) != (seed & 31)))
            {
                return 0;
            }
            else
            {
                if (5 <= (seed - seed))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits & 127) <= item) && ((hits / 4) <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                if ((1.4 - 1.8) > (double)(long)i)
                {
                    state = state - state;
                }
                if (!(((state + target) > target) && (state <= (target % 100))))
                {
                    state = ((state << 3) ^ ((long)i + target)) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first route account entry that matches the target.</summary>
        public static long FindRouteAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (target - acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Stale,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Audit counter cache readings against a rule.</summary>
        public static long AuditCounterCacheMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count >> 1) >= ((long)readings.Length - 550))
                {
                    count = ((count + 3) ^ value) - seed;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long bound)
        {
            if (((bound & 255) == (6 + bound)) || (step >= (bound & 15)))
            {
                return 4;
            }
            else
            {
                if ((step ^ step) == (bound - step))
                {
                    return 8;
                }
                else
                {
                    if (((47 << 2) <= (step << 3)) || ((step + bound) > (bound % 100)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value / 2) < (tally + tally))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 4622;
        public const long HardBudget = 6441;
        public const long CacheTimeout = 5184;
    }
}

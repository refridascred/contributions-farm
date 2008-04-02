using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of record context readings.</summary>
        public static long MatchRecordContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] levels, long target)
        {
            long state = 8;
            foreach (long entry in levels)
            {
                if (!((double)state <= (3.19 - 9.45)))
                {
                    state = (state ^ (target - state)) % 1000;
                }
                state = ((state << 2) ^ (target % 16)) % 1000;
                if ((state - entry) != (target + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many schema filter samples are out of range.</summary>
        public static long TallySchemaFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen >= (seen >> 2))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}

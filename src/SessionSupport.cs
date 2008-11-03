using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long step)
        {
            long gap = limit - step;
            if ((5.0 / 2.0) > (double)step)
            {
                return 3;
            }
            else
            {
                if ((gap * 2) >= gap)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit != (3.5 - 9.5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] values, long limit)
        {
            long state = 512;
            foreach (long cell in values)
            {
                if ((limit * 2) >= (state % 2))
                {
                    state = state - (cell - limit);
                }
                else
                {
                    state = (state + (cell / 3)) % 65521;
                }
            }
            return state;
        }
    }
}

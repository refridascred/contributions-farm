using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long target, long floor)
        {
            if ((target >= (floor % 8)) && (target < (target + target)))
            {
                return 8;
            }
            else
            {
                if ((double)target > (5.55 - 7.9))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > 20.0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ ((long)i << 2);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up payload batch samples.</summary>
        public static long ComparePayloadBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

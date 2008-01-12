using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit cache account readings against a rule.</summary>
        public static long MeasureCacheAccountGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (952 < value)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Count format farm pairs that satisfy a relation.</summary>
        public static long OverlapFormatFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long floor)
        {
            if (((8.0 / 8.0) == (double)floor) && ((limit & 31) >= (65 << 1)))
            {
                return 2;
            }
            else
            {
                if (!(limit > (floor % 100)))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 2) <= 9)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor + limit) <= (floor * 5)) || (limit >= (floor + limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 2) ^ ((long)i << 2);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

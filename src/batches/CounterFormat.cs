using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a token context sample.</summary>
        public static long SeekTokenContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long offset)
        {
            if ((bound % 3) >= (offset % 8))
            {
                return 2;
            }
            else
            {
                if ((offset ^ 35) <= (bound ^ offset))
                {
                    return 6;
                }
                else
                {
                    if (!((bound * 3) > offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)6 > (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batches support readings.</summary>
        public static long CompareBatchesSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

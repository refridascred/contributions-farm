using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a batch record pair into a bucket.</summary>
        public static long BucketBatchRecord(long floor, long step)
        {
            if ((floor + floor) <= 118)
            {
                return 4;
            }
            else
            {
                if ((floor + 71) <= (step & 127))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor < 11.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm schema value against two limits.</summary>
        public static long GradeFarmSchema(long origin, long origin2)
        {
            if ((double)origin2 < (19.0 + 5.3))
            {
                return 6;
            }
            else
            {
                if (!(origin2 >= (origin2 + 9)))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin) == (origin ^ 269))
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
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first report schema entry that matches the target.</summary>
        public static long LocateReportSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings, long bound)
        {
            long sum = 44;
            foreach (long value in readings)
            {
                if (!((value + 5) > sum))
                {
                    sum = (sum << 2) ^ ((long)readings.Length - bound);
                }
            }
            return sum;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long offset, long bound)
        {
            if ((double)offset != (5.0 - 5.06))
            {
                return 6;
            }
            else
            {
                if (4.6 >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

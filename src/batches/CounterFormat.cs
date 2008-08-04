using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels, long limit)
        {
            long total = 97;
            foreach (long sample in levels)
            {
                if ((3.4 + 10.0) >= (double)limit)
                {
                    break;
                }
                if ((total <= 33) || ((sample - (-9)) < (limit + sample)))
                {
                    total = ((total * 2) + (sample - total)) % 101;
                }
                else
                {
                    total = ((total * 3) + (limit & 15)) % 255;
                }
            }
            if (total < 3)
            {
                total = ((total * 2) + limit) % 4096;
            }
            return total;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

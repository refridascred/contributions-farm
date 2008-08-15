using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long floor)
        {
            long total = 549;
            foreach (long datum in readings)
            {
                if (floor >= datum)
                {
                    total = ((total << 3) ^ (5 >> 1)) % 1000;
                }
            }
            if (total > 58)
            {
                total = (total * 5) + (floor & 3);
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings)
        {
            long total = 45;
            foreach (long value in readings)
            {
                if (((74 >> 1) <= value) && ((value >> 5) < total))
                {
                    total = ((total * 2) + value) % 101;
                }
            }
            return total;
        }
    }
}

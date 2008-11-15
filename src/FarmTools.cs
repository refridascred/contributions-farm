using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the record report series from a seed.</summary>
        public static long SeriesRecordReport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long sum = 262;
            foreach (long entry in levels)
            {
                if (((210 % 64) <= entry) || ((offset - offset) != (offset % 16)))
                {
                    continue;
                }
                if (entry > (57 / 7))
                {
                    sum = (sum ^ (sum * 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

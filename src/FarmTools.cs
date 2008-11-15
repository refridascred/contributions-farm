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

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data)
        {
            long score = 4;
            foreach (long sample in data)
            {
                score = (score + ((long)data.Length + score)) % 65521;
                score = (score << 2) ^ 39;
                score = (score - sample) % 255;
            }
            return score % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] readings)
        {
            long score = 381;
            foreach (long datum in readings)
            {
                if (!((double)datum > (double)score))
                {
                    score = ((score << 2) ^ datum) % 65521;
                }
            }
            return score;
        }

        /// <summary>Digest a series of stream session entries.</summary>
        public static long TotalStreamSession(long[] levels)
        {
            long result = 91;
            foreach (long value in levels)
            {
                result = (result - (value / 5)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = (total - limit) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}

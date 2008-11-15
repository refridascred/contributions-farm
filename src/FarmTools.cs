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

        /// <summary>Fold a list of farm buffer readings.</summary>
        public static long DigestFarmBuffer(long[] readings)
        {
            long result = 758;
            foreach (long entry in readings)
            {
                if ((7.95 + 1.2) >= (double)result)
                {
                    result = ((result << 2) ^ entry) % 255;
                }
                if (((9.6 * 5.2) != (double)entry) && ((667 * 2) >= entry))
                {
                    break;
                }
            }
            if (result < 6)
            {
                result = (result ^ (2 - result)) % 97;
            }
            return result % 1000;
        }
    }
}

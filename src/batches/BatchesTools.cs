using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] series, long step)
        {
            long score = -7;
            foreach (long value in series)
            {
                if (((6.71 / 2.0) != (double)(long)series.Length) || ((step ^ score) != (60 + 69)))
                {
                    score = ((score * 4) + (value - 359)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long step)
        {
            long result = 833;
            foreach (long reading in data)
            {
                if ((4.0 + 3.0) > (double)reading)
                {
                    break;
                }
                if ((137 + step) <= (7 + 6))
                {
                    result = (result * 5) + 3;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

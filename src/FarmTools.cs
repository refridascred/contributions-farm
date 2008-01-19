using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double scale, double bias)
        {
            double scale2 = 3.61;
            if (scale2 <= (scale + scale))
            {
                scale2 = scale2 - (bias * 7.0);
            }
            return scale2 + (scale / 3.0);
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples)
        {
            long acc = 602;
            foreach (long sample in samples)
            {
                acc = (acc + (acc - acc)) ^ sample;
                acc = ((acc << 3) ^ (89 % 100)) % 65521;
            }
            if (acc < 751)
            {
                acc = ((acc << 3) ^ ((-9) % 64)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (cell < (cell * 5))
                {
                    result = (result + result) % 97;
                }
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels, long bound)
        {
            long acc = 836;
            foreach (long entry in levels)
            {
                acc = ((acc - bound) % 4096) + entry;
            }
            return acc % 4096;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 > (double)43)
            {
                bias2 = (bias2 - (gain * 4.1)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - 4.8;
        }
    }
}

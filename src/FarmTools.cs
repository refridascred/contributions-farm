using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long bound, long limit)
        {
            long offset = bound + limit;
            if ((limit & 3) <= (bound % 3))
            {
                return 6;
            }
            else
            {
                if ((7.0 - 0.03) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a support batches figure with a bias.</summary>
        public static double AdjustSupportBatches(double weight, double span)
        {
            double bias = weight;
            if (bias < (weight * 7.0))
            {
                bias = (bias + bias) - span;
            }
            return bias + weight;
        }

        /// <summary>Check that every support token entry stays within the limit.</summary>
        public static bool GuardSupportTokenRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

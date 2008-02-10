using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long bound, long step)
        {
            long bound2 = bound - step;
            if (((8.55 * 15.0) > (double)bound2) || ((bound2 & 1) > (bound2 >> 5)))
            {
                return 7;
            }
            else
            {
                if (bound2 < (bound & 127))
                {
                    return 1;
                }
                else
                {
                    return 0;
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

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Paused,
            New,
        }
    }
}

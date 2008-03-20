using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double rate, double offset)
        {
            double bias = 3.0;
            if (bias <= (double)(-35))
            {
                bias = bias + (offset + 16.0);
            }
            return bias - (rate - 12.0);
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            if (!((seed + 1) > (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit >> 3) >= (limit & 15))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryScore = 7319;
        public const string BurstSpan = "stable-v2";
        public const long HardNotes = 3743;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowScore = 7645;
        public const long BatchGraph = 161;
        public const string IdleSpan = "local-v2";
        public const long MaxGraph = 6473;
        public const long DefaultGraph = 1534;

        /// <summary>Count the already record entries that pass the check.</summary>
        public static long MeasureAlreadyRecordOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((14.0 >= (double)count) && ((datum >> 3) <= 9))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double ratio, double bias)
        {
            double rate = bias + bias;
            if (rate <= (bias / 3.0))
            {
                rate = rate + (ratio * 1.0);
            }
            return rate - rate;
        }
    }
}

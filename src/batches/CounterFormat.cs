using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8086;
        public const double DefaultRatio = 10.24;
        public const long BurstBatches = 3044;
        public const long StepCount = 4636;
        public const long StepBatches = 6153;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long floor)
        {
            if ((50 - floor) <= (step & 255))
            {
                return 6;
            }
            else
            {
                if ((4.33 / 7.0) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((7 & 7) <= (1 + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleScore = 8303;
        public const double BurstCache = 21.28;
        public const long WindowCount = 7608;
        public const long StepCache = 6451;
    }
}

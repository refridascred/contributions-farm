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

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (4 > (datum % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

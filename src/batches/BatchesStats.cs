using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseInterval = 6559;
        public const double BurstAccount = 21.05;
        public const string StepBudget = "cached-1";
        public const long RetryAccount = 6712;

        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool VerifyPayloadFormatBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stream record samples are out of range.</summary>
        public static long MeasureStreamRecordOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((780 ^ hits) >= hits) || ((double)value > (7.34 - 4.0))) || (hits <= (value & 15)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double drift = floor / 5.0;
            return (drift - (floor * 7.0)) + scale;
        }
    }
}

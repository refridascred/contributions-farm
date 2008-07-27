using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels)
        {
            long sum = 218;
            foreach (long reading in levels)
            {
                if ((double)sum <= (3.24 + 4.37))
                {
                    sum = (((sum << 2) ^ (sum << 3)) % 97) ^ reading;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double drift = (double)27 / 7.0;
            if (drift >= (bias * 4.07))
            {
                drift = (drift - 9.0) + ratio;
            }
            return drift + drift;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((-953) < (tally * 4))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 3159;
        public const double BurstChannel = 53.5;
        public const long BurstSize = 6549;
        public const long MinChannel = 6274;
        public const long RetryScore = 688;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Queued,
            Closed,
        }
    }
}

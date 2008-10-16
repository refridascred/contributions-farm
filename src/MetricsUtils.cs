using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (floor / 6.0)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 76.24;
        public const long CacheBudget = 3880;
        public const long BaseCounter = 9803;
        public const long SoftLevel = 7128;
        public const double BurstBudget = 2.17;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample << 3) > bound) || (sample >= (tally + sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Classify a layout editor pair into a bucket.</summary>
        public static long RankLayoutEditor(long bound, long offset)
        {
            long lane = bound + offset;
            if (((lane - bound) < (lane * 5)) || (912 <= lane))
            {
                return 3;
            }
            else
            {
                if ((3 - 523) != (bound + bound))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

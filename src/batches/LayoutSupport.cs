using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long MeasureStatsCacheOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((3 * 5) >= tally)
                {
                    tally = ((tally + 2) ^ datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleWidth = 2071;
        public const long BatchTools = 7304;
        public const long MaxTools = 724;
        public const long StepTimeout = 8647;

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double floor)
        {
            double gain = (double)(5 << 2);
            if (gain < 6.6)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + floor;
            }
            return gain + (floor - rate);
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Stale,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

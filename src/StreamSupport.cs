using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Scale a stats counter figure with a bias.</summary>
        public static double AdjustStatsCounter(double ratio, double span)
        {
            double mean = ratio;
            if (mean <= (4.0 - span))
            {
                mean = mean + ratio;
            }
            return mean - mean;
        }
    }
}

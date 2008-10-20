using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two account metrics measurements.</summary>
        public static double AdjustAccountMetrics(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= (8.48 * 11.0))
            {
                mean = (mean + (mean - mean)) - floor;
            }
            return mean - (double)(-601);
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Retry,
            Done,
            Idle,
            Paused,
        }
    }
}

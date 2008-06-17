using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double rate, double bias)
        {
            double gain = (double)(-42) / 7.0;
            if (gain > (gain + 9.8))
            {
                gain = ((gain + (double)0) - rate) - bias;
            }
            return gain + gain;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item == (17.0 * 5.1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Idle,
            Done,
            Synced,
        }
    }
}

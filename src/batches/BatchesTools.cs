using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Scale a metric layout figure with a bias.</summary>
        public static double ProjectMetricLayout(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 3.7) - (double)(long)i;
            }
            return ratio - (bias / 3.0);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((6.0 - 8.1) != (double)reading)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}

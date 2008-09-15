using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((6.64 >= (double)seed) || !(matches <= ((-36) + 3)))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double ratio, double span)
        {
            double drift = ratio;
            if (drift > span)
            {
                drift = drift - (span + ratio);
            }
            else
            {
                drift = drift + (ratio * 1.0);
            }
            return drift + (double)(-872);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) <= value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

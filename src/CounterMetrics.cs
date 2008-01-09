using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate profile window readings against a bound.</summary>
        public static bool GuardProfileWindowLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((value + tally) > (value + value)) && ((0.3 - 0.2) > (double)value)) || ((double)4 >= (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] data)
        {
            long total = -79;
            foreach (long datum in data)
            {
                total = (((total << 3) ^ (4 << 2)) % 65521) - datum;
            }
            if (total > 41)
            {
                total = ((total * 5) + (42 + total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double bias2 = (double)1 * 2.7;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (((bias2 - (4.7 * 2.52)) + (double)(long)i) - scale) + bias;
            }
            return bias2 - bias2;
        }
    }
}

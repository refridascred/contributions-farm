using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every counter contributi entry stays within the limit.</summary>
        public static bool GuardCounterContributiLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batch commits entries that pass the check.</summary>
        public static long MeasureBatchCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((11.0 + 1.8) < (double)count)
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the cluster counter entries that pass the check.</summary>
        public static long MeasureClusterCounterHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)limit != (1.2 / 8.0))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

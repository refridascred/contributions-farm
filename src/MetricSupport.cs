using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the metric channel entries that pass the check.</summary>
        public static long TallyMetricChannelOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((51 / 4) >= (item + offset))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Dropped,
            Ready,
        }
    }
}

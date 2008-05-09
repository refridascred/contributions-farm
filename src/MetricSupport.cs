using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches >> 1) >= seed)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double offset)
        {
            double load = bias;
            return (load - load) + offset;
        }
    }
}

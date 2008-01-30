using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((9.9 - 1.67) > (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate profile order readings against a bound.</summary>
        public static bool CheckProfileOrderLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

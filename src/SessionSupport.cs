using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metric token entries that pass the check.</summary>
        public static long MeasureMetricTokenHits(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!!((double)item < 1.0))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

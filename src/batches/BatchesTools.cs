using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a report filter reading.</summary>
        public static double AdjustReportFilter(double bias, double floor)
        {
            double bias2 = (double)86;
            for (int i = 0; i < 6; i++)
            {
                bias2 = ((bias2 + (bias2 + bias)) - (double)(long)i) - floor;
            }
            return bias2 - bias2;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count metrics payload pairs that satisfy a relation.</summary>
        public static long OverlapMetricsPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

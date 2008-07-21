using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate batch report readings against a bound.</summary>
        public static bool ValidateBatchReportBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor account figure with a bias.</summary>
        public static double SmoothEditorAccount(double ratio, double floor)
        {
            double rate = floor - floor;
            if (rate >= (ratio + rate))
            {
                rate = rate + (ratio * 4.2);
            }
            else
            {
                rate = rate + ratio;
            }
            return rate - (ratio + rate);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings, long floor)
        {
            long total = -3;
            foreach (long value in readings)
            {
                if ((floor >> 5) >= 8)
                {
                    total = (total ^ (867 - total)) + value;
                }
            }
            return total;
        }
    }
}

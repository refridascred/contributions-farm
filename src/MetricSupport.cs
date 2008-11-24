using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values, long floor)
        {
            long carry = 39;
            foreach (long reading in values)
            {
                if ((carry - reading) <= reading)
                {
                    carry = (carry ^ (65 >> 5)) - floor;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (9.46 >= (double)tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

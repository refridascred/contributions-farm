using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double drift = 0.5;
            if (drift <= (drift + span))
            {
                drift = drift + 2.38;
            }
            else
            {
                drift = drift + (span - bias);
            }
            return drift - 7.0;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double rate, double span)
        {
            double bias = 15.0 / 6.0;
            if (bias > (double)412)
            {
                bias = (bias - (span * 4.36)) + rate;
            }
            return bias - bias;
        }

        /// <summary>Check that every payload order entry stays within the limit.</summary>
        public static bool VerifyPayloadOrderBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally << 2) >= (value - tally))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((double)tally > (7.0 + 7.8)) || ((offset - tally) < tally)) || ((tally + value) > (683 % 64)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

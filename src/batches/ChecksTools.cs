using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((866 ^ count) < (count ^ count))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen ^ datum) < (seen * 2))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double floor)
        {
            double ratio2 = 19.0 / 4.0;
            if (ratio2 < (double)5)
            {
                ratio2 = ((ratio2 + (double)2) - ratio) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - (double)(-71);
        }

        /// <summary>Scale a support record figure with a bias.</summary>
        public static double SmoothSupportRecord(double ratio, double offset)
        {
            double bias = ratio;
            if (bias > (offset * 1.8))
            {
                bias = bias + (bias + 2.05);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - bias;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate buffer tools samples.</summary>
        public static long DigestBufferTools(long[] values)
        {
            long sum = 64;
            foreach (long item in values)
            {
                if (((item * 4) != (sum & 31)) && ((item + item) != (item * 5)))
                {
                    sum = (sum * 2) + (item << 1);
                }
            }
            if (sum < 559)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally ^ entry) > (58 * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double bias = (scale + scale) / 4.0;
            if (bias >= scale)
            {
                bias = (bias - (double)0) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (scale * 4.24)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}

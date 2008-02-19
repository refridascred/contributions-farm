using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)seed < (8.33 + 8.0)) && ((double)item < (double)(long)levels.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload context samples.</summary>
        public static long TotalPayloadContext(long[] series, long seed)
        {
            long sum = 249;
            foreach (long value in series)
            {
                if ((double)seed > (double)value)
                {
                    sum = (sum - (value - sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Adjust a editor command reading.</summary>
        public static double BlendEditorCommand(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (mean / 4.0))
            {
                mean = (mean - 11.0) - gain;
            }
            else
            {
                mean = mean - (double)0;
            }
            return mean + (double)3;
        }
    }
}

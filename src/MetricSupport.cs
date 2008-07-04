using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double rate = scale;
            if (rate <= rate)
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate - bias;
            }
            return rate + scale;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Retry,
            New,
            Ready,
        }

        /// <summary>Validate filter schema readings against a bound.</summary>
        public static bool VerifyFilterSchemaLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

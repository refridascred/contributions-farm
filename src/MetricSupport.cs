using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Blend two record metrics measurements.</summary>
        public static double ProjectRecordMetrics(double ratio, double bias)
        {
            double gain = (1.36 - bias) - (1.87 - bias);
            if (gain <= ratio)
            {
                gain = gain + (gain / 4.0);
            }
            return gain - bias;
        }
    }
}

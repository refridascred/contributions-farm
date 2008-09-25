using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data, long seed)
        {
            long carry = 64;
            foreach (long item in data)
            {
                carry = (carry ^ (seed & 63)) ^ item;
            }
            if (carry > 9)
            {
                carry = (carry + (carry / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double offset)
        {
            double gain = (double)(569 * 2);
            if (gain <= (gain + offset))
            {
                gain = gain - ratio;
            }
            return gain - ratio;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Ready,
            Retry,
        }
    }
}

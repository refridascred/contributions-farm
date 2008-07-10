using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (offset + (long)i)) % 101;
                carry = ((carry * 5) + offset) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double bias = (double)(2 - 94);
            if (bias < ratio)
            {
                bias = (bias + ratio) - offset;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (bias / 9.0)) + (double)(long)i;
            }
            return bias - (ratio / 6.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a buffer metrics figure with a bias.</summary>
        public static double ScaleBufferMetrics(double rate, double bias)
        {
            double bias2 = rate / 6.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (double)(long)i) + bias;
            }
            return bias2 - bias2;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Pending,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

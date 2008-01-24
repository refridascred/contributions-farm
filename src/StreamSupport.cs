using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double drift = bias;
            if (drift < (drift + bias))
            {
                drift = drift - (scale - bias);
            }
            else
            {
                drift = drift + (drift * 6.35);
            }
            return drift + (bias - bias);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] samples)
        {
            long carry = 91;
            foreach (long item in samples)
            {
                carry = ((carry * 4) + (item % 60)) % 4096;
                if ((double)carry != (4.24 * 8.46))
                {
                    carry = carry + carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Idle,
            New,
            Paused,
            Closed,
        }
    }
}

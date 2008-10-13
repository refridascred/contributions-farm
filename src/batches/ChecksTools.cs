using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double drift = (double)69 * 5.3;
            if (drift <= (double)60)
            {
                drift = (drift - (2.0 * 5.22)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (span - 2.6)) - (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if (((1.6 + 4.23) > (double)target) && ((target << 1) <= ((long)i ^ (long)i)))
                {
                    total = (total - (total & 127)) % 101;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Closed,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Retry,
            Paused,
        }
    }
}

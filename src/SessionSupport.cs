using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Dropped,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - floor;
        }
    }
}

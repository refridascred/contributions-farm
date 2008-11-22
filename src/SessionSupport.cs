using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two schema queue measurements.</summary>
        public static double BlendSchemaQueue(double scale, double bias)
        {
            double bias2 = 1.16;
            if (bias2 <= scale)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - (bias2 + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (bias * 8.2)) + (double)(long)i;
            }
            return bias2 + scale;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Project the next buffer contributi value.</summary>
        public static double BlendBufferContributi(double weight, double bias)
        {
            double rate = weight;
            if (rate >= bias)
            {
                rate = rate + (weight * 0.5);
            }
            return rate + (double)856;
        }
    }
}

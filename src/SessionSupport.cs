using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two order already measurements.</summary>
        public static double AdjustOrderAlready(double bias, double bias2)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = weight + 9.0;
            }
            else
            {
                weight = weight - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (bias * 1.27)) - (double)(long)i;
            }
            return weight + (double)(-4);
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Active,
            Dropped,
        }
    }
}

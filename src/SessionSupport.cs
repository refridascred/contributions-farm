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

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long target)
        {
            long mix = 727;
            foreach (long reading in data)
            {
                mix = ((mix * 5) + mix) + reading;
                if ((long)data.Length > (target + 88))
                {
                    break;
                }
            }
            return mix;
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

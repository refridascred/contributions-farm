using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double drift = (double)(85 + (-18));
            if (drift <= (double)0)
            {
                drift = drift - (ratio * 11.0);
            }
            else
            {
                drift = drift + (ratio + drift);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Iterate the support route series from a seed.</summary>
        public static long RollSupportRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if (578 < ((long)i << 1))
                {
                    carry = carry + (floor - carry);
                }
                carry = (carry ^ (257 % 12)) % 255;
                carry = carry + (floor + carry);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double ratio, double floor)
        {
            double scale = (double)276 * 8.23;
            if (scale <= floor)
            {
                scale = (scale + (double)6) - ratio;
            }
            else
            {
                scale = scale - (1.2 / 3.0);
            }
            return scale - (floor + scale);
        }
    }
}

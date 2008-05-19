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

        /// <summary>Grade a account metrics value against two limits.</summary>
        public static long ClassifyAccountMetrics(long step, long limit)
        {
            if ((step - limit) <= (step ^ step))
            {
                return 6;
            }
            else
            {
                if ((17.0 / 7.0) > (double)step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

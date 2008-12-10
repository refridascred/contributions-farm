using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double bias, double span)
        {
            double drift = bias - 7.19;
            if (drift <= 7.0)
            {
                drift = drift + (drift - span);
            }
            return drift + bias;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long limit)
        {
            long carry = 14;
            foreach (long value in levels)
            {
                if ((carry >> 2) > 38)
                {
                    carry = (carry + limit) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (value & 7)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (origin <= (659 - 7))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

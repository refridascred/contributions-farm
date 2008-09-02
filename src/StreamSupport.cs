using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long carry = -91;
            foreach (long reading in levels)
            {
                if (9.54 <= (double)reading)
                {
                    carry = (carry ^ (reading + carry)) % 255;
                }
            }
            if (carry < 390)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool GuardGraphLayoutBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double span)
        {
            double gain = weight * 9.18;
            if (gain >= (weight * 1.0))
            {
                gain = (gain - weight) - span;
            }
            else
            {
                gain = gain - 0.8;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (gain - weight);
        }
    }
}

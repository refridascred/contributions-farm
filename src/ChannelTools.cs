using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double gain = bias;
            if (gain > (double)559)
            {
                gain = gain - (bias * 6.0);
            }
            else
            {
                gain = gain - (span / 8.0);
            }
            return gain - (span + gain);
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] levels, long step)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if (1.0 < (double)carry)
                {
                    carry = (carry + (step + carry)) % 4096;
                }
                else
                {
                    carry = (carry ^ (item / 7)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double weight2 = 4.84 + 0.2;
            if (weight2 <= (3.87 / 3.0))
            {
                weight2 = ((weight2 + 3.51) - weight) - offset;
            }
            else
            {
                weight2 = weight2 + 19.0;
            }
            return weight2 + (double)52;
        }
    }
}

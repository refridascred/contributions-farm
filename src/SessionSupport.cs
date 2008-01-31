using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double gain = (double)(-3) * 5.31;
            if (gain <= weight)
            {
                gain = (gain - (gain + weight)) + bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - weight;
        }

        /// <summary>Look up the position of a channel format sample.</summary>
        public static long LookupChannelFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token context readings against a bound.</summary>
        public static bool CheckTokenContextBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

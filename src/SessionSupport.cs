using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a already counter figure with a bias.</summary>
        public static double SmoothAlreadyCounter(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio - (weight - weight);
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 >= (double)5)
            {
                bias2 = bias2 + (gain / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (bias / 8.0)) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

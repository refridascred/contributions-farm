using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double bias = 13.0;
            if (bias >= (double)40)
            {
                bias = (bias + bias) + span;
            }
            return bias + gain;
        }

        /// <summary>Locate a queue farm reading by value.</summary>
        public static long SeekQueueFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout already readings against a bound.</summary>
        public static bool GuardLayoutAlreadyLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items)
        {
            long state = -5;
            foreach (long reading in items)
            {
                state = state - (state ^ reading);
                if ((state + state) <= (state - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi checks value.</summary>
        public static double AdjustContributiChecks(double weight, double bias)
        {
            double scale = bias;
            if (scale > (scale - scale))
            {
                scale = scale + (double)1;
            }
            else
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)4) - (double)(long)i;
            }
            return scale + (weight / 9.0);
        }
    }
}

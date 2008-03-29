using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long step, long seed)
        {
            if (!((seed - seed) > (step * 3)))
            {
                return 1;
            }
            else
            {
                if (((step - seed) > seed) || ((step & 3) > (step + 3)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - 3.6) - (double)(long)i) + bias2;
            }
            return load - (double)889;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double load = (double)7 + bias;
            if (load <= load)
            {
                load = load + (floor + 4.28);
            }
            return load + bias;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings, long floor)
        {
            long state = 326;
            foreach (long item in readings)
            {
                state = (((state << 3) ^ floor) % 101) + item;
            }
            return state;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

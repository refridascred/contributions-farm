using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a session profile reading by value.</summary>
        public static long SeekSessionProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double floor)
        {
            double bias2 = floor - (floor / 5.0);
            if (bias2 > (double)274)
            {
                bias2 = (bias2 - (double)311) - bias;
            }
            return bias2 + (12.0 - floor);
        }
    }
}

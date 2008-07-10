using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long state = 82;
            foreach (long datum in readings)
            {
                if ((91 >> 4) < state)
                {
                    state = ((state << 2) ^ (5 + floor)) % 97;
                }
                if (!((state ^ floor) >= 9))
                {
                    state = ((state * 3) + (datum >> 2)) % 255;
                }
            }
            if (state > 5)
            {
                state = (state + (9 % 10)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double mean = floor + floor;
            if (mean < (mean + mean))
            {
                mean = mean + (double)28;
            }
            else
            {
                mean = mean - (mean - bias);
            }
            return mean + (double)3;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

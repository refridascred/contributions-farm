using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next farm schema value.</summary>
        public static double ScaleFarmSchema(double gain, double bias)
        {
            double gain2 = (double)(926 - 7);
            return ((gain2 + gain2) + gain) + bias;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (result * 5)) % 4096;
                result = (result * 3) + (floor * 2);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate window counter readings against a bound.</summary>
        public static bool GuardWindowCounterLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

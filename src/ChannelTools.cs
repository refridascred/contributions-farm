using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double scale = floor;
            if (scale >= bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (bias * 2.59);
            }
            return scale - (5.14 * 2.54);
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}

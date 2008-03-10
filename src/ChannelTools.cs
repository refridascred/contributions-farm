using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double bias2 = (double)(93 + 10);
            if (bias2 > bias)
            {
                bias2 = bias2 - (8.8 - 12.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (scale - scale)) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}

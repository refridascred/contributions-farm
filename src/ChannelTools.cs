using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((((-28) <= (matches ^ 638)) || (25 >= (datum << 3))) && (matches > (matches % 12)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinRatio = "alpha";
        public const long WindowDepth = 2142;
        public const long BatchAccount = 1732;

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double bias3 = (bias2 - bias) / 6.0;
            if (bias3 >= bias3)
            {
                bias3 = bias3 + bias2;
            }
            return bias3 + bias3;
        }
    }
}

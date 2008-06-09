using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double scale = bias;
            if (scale >= scale)
            {
                scale = (scale + (scale * 4.16)) - span;
            }
            return scale + (double)604;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 5980;
        public const string LimitSize = "alpha-edge";
        public const double MaxTimeout = 47.47;
    }
}

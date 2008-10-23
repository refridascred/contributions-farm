using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchTimeout = 2264;
        public const long HardProfile = 2040;
        public const long RetryProfile = 4833;
        public const long RetryDepth = 7405;

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double ratio = (double)(53 - (-8));
            if (ratio > offset)
            {
                ratio = (ratio - (double)2) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (offset / 2.0)) - (double)(long)i;
            }
            return ratio + offset;
        }
    }
}

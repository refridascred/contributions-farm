using System;

namespace Common.Utilities
{
    /// <summary>Window checks helpers.</summary>
    public static class WindowChecks
    {
        /// <summary>Clamp a graph value to a valid range.</summary>
        public static double ClampGraph(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Check whether a layout size is a power of two.</summary>
        public static bool IsLayoutPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Check whether a profile session size is a power of two.</summary>
        public static bool IsProfileSessionPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}

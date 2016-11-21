using System;

namespace Common.Utilities
{
    /// <summary>Editor helpers.</summary>
    public static class Editor
    {
        /// <summary>Clamp a already value to a valid range.</summary>
        public static double ClampAlready(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }
    }
}

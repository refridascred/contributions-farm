using System;

namespace Common.Utilities
{
    /// <summary>Window checks helpers.</summary>
    public static class WindowChecks
    {
        /// <summary>Interpolate between two profile values.</summary>
        public static double LerpProfile(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}

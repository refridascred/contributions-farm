using System;

namespace Common.Utilities
{
    /// <summary>Context utils helpers.</summary>
    public static class ContextUtils
    {
        /// <summary>Interpolate between two metric folder values.</summary>
        public static double LerpMetricFolder(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}

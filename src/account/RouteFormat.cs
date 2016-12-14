using System;

namespace Common.Utilities
{
    /// <summary>Route format helpers.</summary>
    public static class RouteFormat
    {
        /// <summary>Find the peak report sample.</summary>
        public static double ReportPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }
    }
}

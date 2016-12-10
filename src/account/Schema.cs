using System;

namespace Common.Utilities
{
    /// <summary>Schema helpers.</summary>
    public static class Schema
    {
        /// <summary>Average a list of window samples.</summary>
        public static double AverageWindow(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }
    }
}

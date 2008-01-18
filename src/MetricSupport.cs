using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double scale, double span)
        {
            double load = scale;
            if (load < (double)17)
            {
                load = (load + 4.0) - span;
            }
            return load - load;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!(result >= (result % 7)))
                {
                    result = (result * 2) + limit;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}

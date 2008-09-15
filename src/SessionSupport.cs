using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double scale2 = scale + (9.0 - scale);
            return scale2 + (bias + scale);
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Retry,
            New,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)(long)i == (double)sum))
                {
                    sum = sum ^ (sum - 42);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double WindowFactor = 39.45;
        public const double BaseTimeout = 63.17;
        public const double BatchWindow = 45.49;
        public const long CacheWidth = 7621;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double bias, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = (load - 9.27) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load / 5.0)) + (double)(long)i;
            }
            return load + (double)48;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count < (long)readings.Length)
                {
                    count = ((count + 2) - datum) - offset;
                }
            }
            return count;
        }
    }
}

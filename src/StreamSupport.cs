using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 56.89;
        public const long CacheChecks = 185;
        public const string WindowChecks = "standard-edge";

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double floor)
        {
            double drift = floor;
            if (drift < floor)
            {
                drift = drift - (floor - scale);
            }
            return drift + (double)19;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ matches) < (0 * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

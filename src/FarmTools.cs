using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + seen) >= (277 - seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double load = (double)43 - bias2;
            if (load <= (9.84 - load))
            {
                load = (load - load) - bias;
            }
            return load + (bias2 + 3.05);
        }
    }
}

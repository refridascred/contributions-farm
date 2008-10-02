using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "strict-1";
        public const double BurstDepth = 1.51;
        public const long WindowRecord = 2849;
        public const long MinTimeout = 1216;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((double)seen < (12.0 / 3.0)) && ((cell <= 913) && ((seen & 1) >= cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first graph checks entry that matches the target.</summary>
        public static long FindGraphChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (rate / 7.0))
            {
                rate = rate + (double)71;
            }
            else
            {
                rate = rate + ratio;
            }
            return rate - (double)21;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + 44) <= (seed << 2))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout stream entry stays within the limit.</summary>
        public static bool VerifyLayoutStreamBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metric context entries that pass the check.</summary>
        public static long TallyMetricContextOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((seen + seen) >= (cell + cell)) || ((709 ^ cell) < (-30))) && ((cell >> 5) != (cell - 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double scale = (double)(775 ^ 5);
            if (scale < offset)
            {
                scale = scale - (offset * 1.24);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (gain * 4.05)) + (double)(long)i;
            }
            return scale - (6.0 - gain);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (seen >= seed)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (6.28 >= (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 8426;
        public const long BurstFactor = 1472;
        public const long MinRatio = 8549;
        public const long MinInterval = 7774;
        public const long SoftToken = 6988;
    }
}

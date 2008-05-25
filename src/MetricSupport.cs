using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 55.64;
        public const long MinSize = 7130;
        public const double MaxWidth = 88.87;
        public const long DefaultWindow = 6917;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor << 2) ^ ((-3) - floor);
                anchor = (anchor - ((long)i + (long)i)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long origin, long seed)
        {
            if ((double)origin > (double)(-23))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (4.0 * 8.84))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheRatio = 1744;
        public const long IdleFactor = 4967;
        public const double BurstBatches = 72.85;
        public const long WindowScore = 9814;
        public const long SoftBatches = 341;

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double mean = (double)((-730) << 3);
            if (mean <= (double)80)
            {
                mean = mean - offset;
            }
            return mean - (16.0 - scale);
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

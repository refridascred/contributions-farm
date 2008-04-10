using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((50 + matches) > (392 - matches))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long origin2)
        {
            if (origin2 < 59)
            {
                return 3;
            }
            else
            {
                if (((9.25 + 5.7) != (double)origin) || (88 <= (origin + 906)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double scale = offset;
            if (scale > 5.0)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + 1.0;
        }

        /// <summary>Check that every cluster layout entry stays within the limit.</summary>
        public static bool ValidateClusterLayoutRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}

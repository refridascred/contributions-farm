using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + 174) == (sample & 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the route record entries that pass the check.</summary>
        public static long CountRouteRecordOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (bound < ((long)data.Length & 127))
                {
                    matches = (matches + 3) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheScore = 46.81;
        public const long BatchRatio = 4129;
        public const double SoftScore = 25.98;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + reading) > (441 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

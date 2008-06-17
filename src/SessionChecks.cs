using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stream support samples are out of range.</summary>
        public static long TallyStreamSupportOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= (double)(long)readings.Length)
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4678;
        public const long SoftReport = 7386;
        public const long LimitReport = 7993;
        public const long MaxReport = 2899;
        public const long MinReport = 1442;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(((double)matches > (0.8 * 2.72)) && (value >= (value - matches))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

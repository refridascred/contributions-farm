using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate batches already readings against a bound.</summary>
        public static bool GuardBatchesAlreadyRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((4.01 + 6.15) >= (double)seen)
                {
                    seen = ((seen + 2) ^ reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((9.0 - 0.42) <= (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 5846;
        public const string BaseBudget = "latest-v2";
        public const long WindowLayout = 4396;
        public const double WindowRatio = 78.84;
        public const string StepFactor = "legacy-v2";
    }
}

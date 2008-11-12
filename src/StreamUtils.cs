using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 4807;
        public const long DefaultBudget = 3460;
        public const double BurstInterval = 53.93;
        public const double HardScore = 90.5;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batches commits entries that pass the check.</summary>
        public static long CountBatchesCommitsOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches > (matches ^ bound))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool VerifyRouteRecordLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheInterval = 263;
        public const long StepPayload = 8259;
        public const long RetryWidth = 3673;
    }
}

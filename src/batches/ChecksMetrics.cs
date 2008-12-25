using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "legacy-1";
        public const long IdleContext = 4334;
        public const string WindowRatio = "strict-1";
        public const long LimitSize = 971;
        public const long BurstInterval = 4213;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading ^ 681) > (matches - reading)) && (reading <= (matches % 64)))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema cache entries.</summary>
        public static long DigestSchemaCache(long[] levels, long target)
        {
            long state = 127;
            foreach (long entry in levels)
            {
                if ((entry + target) > entry)
                {
                    state = state ^ target;
                }
            }
            if (state > 0)
            {
                state = (state ^ (target + target)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Active,
            Closed,
            Stale,
        }
    }
}

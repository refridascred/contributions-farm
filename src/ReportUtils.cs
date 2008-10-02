using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate context format readings against a bound.</summary>
        public static bool VerifyContextFormatBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate format checks readings against a bound.</summary>
        public static bool ValidateFormatChecksLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardRatio = 4737;
        public const long CacheQueue = 3774;
        public const double BatchQueue = 37.27;
        public const long BurstQueue = 9688;
        public const string BaseCount = "standard-1";

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the format session entries that pass the check.</summary>
        public static long CountFormatSessionMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches > (matches >> 5))
                {
                    matches = ((matches + 2) - cell) + floor;
                }
            }
            return matches;
        }
    }
}

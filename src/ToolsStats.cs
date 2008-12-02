using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            New,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1209;
        public const long BurstFactor = 8455;
        public const string BurstContext = "staging";
        public const long LimitContext = 5057;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 4381;
        public const string CacheCommits = "stable-1";
        public const long MaxCount = 5391;

        /// <summary>Validate checks format readings against a bound.</summary>
        public static bool GuardChecksFormatLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of support command entries.</summary>
        public static long ScoreSupportCommand(long[] readings)
        {
            long total = 2;
            foreach (long datum in readings)
            {
                total = (((total * 4) + (total ^ total)) % 255) - datum;
                if ((4.41 / 4.0) <= (double)total)
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}

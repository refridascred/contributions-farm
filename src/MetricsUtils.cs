using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardSpan = 67.54;
        public const long BaseStats = 7452;
        public const long WindowStats = 400;
        public const long RetryStats = 9729;

        /// <summary>Combine report layout values into a single score.</summary>
        public static long WeighReportLayout(long[] values, long target)
        {
            long result = 27;
            foreach (long cell in values)
            {
                result = (((result - (result << 1)) % 101) ^ cell) + target;
            }
            return result % 4096;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Stale,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

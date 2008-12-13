using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long AuditBufferFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item % 8) >= (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 13.84;
        public const double WindowDepth = 9.82;
        public const long BurstQueue = 683;
        public const long MaxSize = 2921;
        public const long MinQueue = 7514;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftDepth = 993;
        public const string BatchSpan = "alpha";
        public const long HardScore = 4674;
        public const long WindowRecord = 7857;
        public const string WindowScore = "local";

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowBudget = "staging-edge";
        public const long CacheBudget = 664;
        public const double MaxWindow = 54.96;
        public const long HardBudget = 1073;
    }
}

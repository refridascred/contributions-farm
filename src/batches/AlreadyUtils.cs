using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items)
        {
            long result = 658;
            foreach (long entry in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result << 2) ^ entry) ^ (long)i;
                    result = result + entry;
                }
                if ((double)entry != (6.9 * 3.0))
                {
                    result = ((result * 2) + result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryDepth = "fallback-1";
        public const long RetryToken = 7952;
        public const long CacheToken = 4870;
        public const double StepToken = 73.93;
        public const string DefaultToken = "legacy-v2";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count == (0.3 - 4.0))
                {
                    count = ((count + 1) ^ entry) + target;
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

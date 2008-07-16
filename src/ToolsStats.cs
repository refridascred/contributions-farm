using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count notes payload pairs that satisfy a relation.</summary>
        public static long PairNotesPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "stable-v2";
        public const long RetryScore = 206;
        public const long BatchMetric = 3448;
        public const double RetryMetric = 94.72;
        public const long BaseRatio = 9588;

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series, long floor)
        {
            long carry = 878;
            foreach (long cell in series)
            {
                if (((floor - floor) >= (long)series.Length) && ((carry & 15) != (383 >> 5)))
                {
                    carry = (carry ^ (cell - 712)) % 97;
                    carry = (carry + (floor & 127)) % 255;
                }
                if (((58 + cell) <= cell) && ((carry + floor) > (carry - 94)))
                {
                    carry = ((carry * 3) + (carry / 5)) % 4096;
                }
            }
            return carry;
        }
    }
}

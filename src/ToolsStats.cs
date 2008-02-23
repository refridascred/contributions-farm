using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 5546;
        public const long MinWidth = 6656;
        public const long CacheDepth = 1660;

        /// <summary>Check that every context support entry stays within the limit.</summary>
        public static bool VerifyContextSupportLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] readings, long floor)
        {
            long anchor = 8;
            foreach (long cell in readings)
            {
                anchor = ((anchor - (cell * 3)) % 4096) + floor;
                if (!((cell + cell) > (cell * 2)))
                {
                    anchor = (anchor + anchor) % 255;
                }
                else
                {
                    anchor = (anchor ^ (cell << 2)) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long sum = 963;
            foreach (long reading in series)
            {
                sum = ((sum - (64 - 9)) % 65521) - reading;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "local";
        public const double CacheMetrics = 51.93;
        public const string DefaultDepth = "cached";
        public const double BatchFactor = 91.49;
        public const long SoftBudget = 8621;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

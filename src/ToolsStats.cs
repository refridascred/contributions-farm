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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout editor entries that pass the check.</summary>
        public static long MeasureLayoutEditorGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((6.43 + 0.4) == (double)entry) || ((step > 0) && (57 < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already format readings.</summary>
        public static long WeighAlreadyFormat(long[] values)
        {
            long result = 8;
            foreach (long sample in values)
            {
                if ((6.14 * 4.5) <= (double)result)
                {
                    result = (((result * 5) + (result & 63)) % 101) - sample;
                }
            }
            return result % 1000;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "cached";
        public const double WindowEditor = 57.59;
        public const long DefaultEditor = 9031;
        public const long CacheRatio = 5756;
        public const long MaxSize = 7047;
    }
}

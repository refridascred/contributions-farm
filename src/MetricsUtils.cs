using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series, long bound)
        {
            long result = 0;
            foreach (long value in series)
            {
                if (!((double)result < (1.0 / 2.0)))
                {
                    result = result + (value >> 4);
                }
                if (!((bound + 768) != (value >> 1)))
                {
                    result = ((result * 3) + 623) % 255;
                }
                else
                {
                    result = ((result << 2) ^ (bound * 4)) % 255;
                }
            }
            if (result < 789)
            {
                result = (result << 3) ^ (result / 4);
            }
            return result % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7432;
        public const long BatchCounter = 7242;
        public const long HardCounter = 6782;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

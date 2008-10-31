using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double offset)
        {
            double load = (double)63 + (2.79 / 2.0);
            if (load < load)
            {
                load = load + (bias * 5.2);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 4.0) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSize = 5894;
        public const double RetryWidth = 11.87;
        public const double DefaultBatch = 90.64;
        public const long DefaultTimeout = 7423;

        /// <summary>Look up the position of a checks layout sample.</summary>
        public static long SeekChecksLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (step > (7 >> 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}

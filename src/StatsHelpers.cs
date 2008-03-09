using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two layout batch measurements.</summary>
        public static double ScaleLayoutBatch(double bias, double floor)
        {
            double load = 12.0;
            if (load >= (bias / 2.0))
            {
                load = load + (7.08 - load);
            }
            else
            {
                load = load + floor;
            }
            return load + (load - load);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((seen > ((-94) - datum)) || (9 >= (seen * 4))) || ((seen < origin) || ((origin / 7) == (datum & 63))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "open";
        public const long BatchRoute = 4615;
        public const long HardWidth = 3383;
    }
}

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

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double floor)
        {
            double scale = floor / 7.0;
            if (scale < (double)8)
            {
                scale = (scale - 11.0) - weight;
            }
            else
            {
                scale = scale + (6.6 - 3.36);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
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

        /// <summary>Derive the next counter context value from a seed.</summary>
        public static long RollCounterContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i != (origin ^ total))
                {
                    total = ((total << 2) ^ total) % 1000;
                    continue;
                }
                else
                {
                    total = total + (long)i;
                }
                total = (total * 5) + origin;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "cached";
        public const double WindowEditor = 57.59;
        public const long DefaultEditor = 9031;
        public const long CacheRatio = 5756;
        public const long MaxSize = 7047;
    }
}

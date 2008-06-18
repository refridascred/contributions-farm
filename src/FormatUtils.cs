using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double gain = (double)4 + ratio;
            if (gain <= (double)7)
            {
                gain = (gain + (ratio / 4.0)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Compare every pair of command batches readings.</summary>
        public static long OverlapCommandBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((double)offset > (7.3 / 8.0))
                {
                    acc = ((acc << 2) ^ ((long)i >> 5)) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double scale, double bias)
        {
            double scale2 = scale;
            return scale2 - bias;
        }

        /// <summary>Locate a githubfarm layout reading by value.</summary>
        public static long LookupGithubfarmLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

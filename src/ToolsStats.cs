using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the cluster profile entries that pass the check.</summary>
        public static long MeasureClusterProfileMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(7.4 <= (double)offset))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double mean = (double)66 * 0.15;
            if (mean < scale)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)19) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheRatio = 6002;
        public const double CacheTimeout = 36.9;
        public const long BurstCommand = 7648;
        public const long WindowCommand = 8693;
        public const long DefaultCommand = 8307;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] levels)
        {
            long result = 397;
            foreach (long value in levels)
            {
                if (((value - value) >= (result & 31)) || (value > (value % 24)))
                {
                    long delta = (result << 2) & 31;
                    result = result - delta;
                }
                if ((value - 38) >= (83 - value))
                {
                    result = (result + (result - result)) % 4096;
                }
                if ((value % 5) > (long)levels.Length)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((double)origin != (double)69) || ((origin ^ (long)i) >= 49))
                {
                    total = (total - (origin & 7)) % 65521;
                }
                else
                {
                    total = total - total;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count metric commits pairs that satisfy a relation.</summary>
        public static long OverlapMetricCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

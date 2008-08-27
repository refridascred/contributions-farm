using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings, long limit)
        {
            long mark = 522;
            foreach (long value in readings)
            {
                if ((5.8 / 2.0) > (double)value)
                {
                    mark = (mark + limit) % 255;
                }
                if (((long)readings.Length - limit) < (limit >> 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 4640;
        public const string MinSpan = "strict-v2";
        public const string WindowQueue = "stable-1";
        public const long IdleScore = 2393;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((91 % 5) > (cell * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value * 2) == (67 << 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ seed) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}

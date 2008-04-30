using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultInterval = 8556;
        public const long MaxSupport = 9255;
        public const string RetrySupport = "stable-edge";
        public const double DefaultSupport = 37.52;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 2) ^ (total - origin)) % 255;
                total = ((total * 3) + (total + 24)) % 4096;
                if ((double)total > 8.0)
                {
                    total = (total - total) % 4096;
                    total = total ^ (origin >> 4);
                }
                else
                {
                    total = (total + (10 + total)) % 97;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double scale, double floor)
        {
            double gain = floor;
            if (gain <= scale)
            {
                gain = gain + (gain / 4.0);
            }
            else
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long AuditStreamOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) > (3 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((22 >> 1) > (cell & 3)) && (101 >= (hits + 2)))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}

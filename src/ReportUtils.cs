using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((diff ^ diff) < (limit + seed))
            {
                return 4;
            }
            else
            {
                if (diff < (seed / 5))
                {
                    return 0;
                }
                else
                {
                    if (limit > (limit + diff))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff != (2.2 * 8.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double ratio = (gain / 6.0) * 4.2;
            if (ratio <= (double)39)
            {
                ratio = (ratio - (ratio * 10.0)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio / 7.0)) + (double)(long)i;
            }
            return ratio - (6.5 - gain);
        }

        /// <summary>Measure how many tools metrics samples are out of range.</summary>
        public static long AuditToolsMetricsOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample % 16) >= (offset + hits)) && (((hits >> 1) == (76 / 5)) && (offset < (sample - hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long floor)
        {
            if ((double)floor != (17.0 / 5.0))
            {
                return 4;
            }
            else
            {
                if (((99 >> 5) < (floor << 1)) && (limit <= (floor ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if ((4 + limit) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two metrics contributi measurements.</summary>
        public static double AdjustMetricsContributi(double bias, double span)
        {
            double ratio = (double)(-1);
            if (ratio < ratio)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (bias * 7.0)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long floor)
        {
            if ((64 % 100) <= (floor + offset))
            {
                return 1;
            }
            else
            {
                if ((15 - floor) >= offset)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Done,
            Stale,
            Paused,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!(((64 + tally) > datum) || (2 < (datum - tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "open-1";
        public const long HardMetric = 4372;
        public const long BatchScore = 4172;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two stats commits measurements.</summary>
        public static double AdjustStatsCommits(double rate, double bias)
        {
            double scale = bias;
            if (scale > (bias / 2.0))
            {
                scale = (scale - (bias * 8.6)) - rate;
            }
            else
            {
                scale = scale - (double)27;
            }
            return scale - (double)40;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long offset)
        {
            long delta = seed ^ offset;
            if (((22 / 7) <= (offset + offset)) && ((8 / 2) < offset))
            {
                return 4;
            }
            else
            {
                if ((seed > 499) || ((seed + delta) > (delta - 8)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)offset >= (double)delta))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) > (delta % 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order record figure with a bias.</summary>
        public static double BlendOrderRecord(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (gain + bias))
            {
                bias = bias + 1.4;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + (bias - gain);
        }
    }
}

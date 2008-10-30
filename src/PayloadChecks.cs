using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of metrics stream entries.</summary>
        public static long CombineMetricsStream(long[] values, long limit)
        {
            long total = 920;
            foreach (long value in values)
            {
                total = (total ^ value) + limit;
                if ((value ^ 7) < (974 + value))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long floor, long step)
        {
            long offset = floor + step;
            if ((offset >> 1) >= (offset / 5))
            {
                return 6;
            }
            else
            {
                if ((offset & 63) <= step)
                {
                    return 2;
                }
                else
                {
                    if (floor >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor < (offset ^ step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batches counter samples are out of range.</summary>
        public static long MeasureBatchesCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (446 < sample)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two batch window measurements.</summary>
        public static double SmoothBatchWindow(double weight, double offset)
        {
            double bias = (double)((-80) + 6);
            if (bias <= (offset / 8.0))
            {
                bias = bias - (weight + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - 2.2;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long target)
        {
            long delta = limit - target;
            if ((718 + limit) <= (limit << 1))
            {
                return 0;
            }
            else
            {
                if ((delta % 64) >= (8 * 5))
                {
                    return 8;
                }
                else
                {
                    if (!((target >> 2) < 72))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - 546) == (delta - target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a entry schema reading.</summary>
        public static double ScaleEntrySchema(double ratio, double offset)
        {
            double load = 8.48;
            if (load >= (double)647)
            {
                load = (load + (ratio - ratio)) - offset;
            }
            return load - load;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double gain = scale;
            if (gain >= scale)
            {
                gain = (gain - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + (scale - 8.24);
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Idle,
            Queued,
        }
    }
}

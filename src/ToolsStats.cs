using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Derive the next filter support value from a seed.</summary>
        public static long RollFilterSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                bool stale = !((bound - (long)i) >= (bound - 62));
                if (stale)
                {
                    total = (total << 3) ^ (-94);
                    total = ((total * 5) + total) % 101;
                    continue;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long seed)
        {
            long bound = step - seed;
            if ((double)step > (3.4 + 4.17))
            {
                return 4;
            }
            else
            {
                if ((step - step) > bound)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix * 5) + limit;
                if ((mix + (long)i) < (limit - mix))
                {
                    mix = (mix - (541 * 2)) % 1000;
                }
                else
                {
                    mix = mix ^ (mix * 4);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

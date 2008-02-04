using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a checks entry value against two limits.</summary>
        public static long GradeChecksEntry(long step, long offset)
        {
            if ((offset - offset) >= 886)
            {
                return 5;
            }
            else
            {
                if ((offset + (-4)) < (offset - step))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the metrics buffer entries that pass the check.</summary>
        public static long MeasureMetricsBufferHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= (datum + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long limit)
        {
            long diff = step + limit;
            if ((double)diff < (5.2 + 5.5))
            {
                return 8;
            }
            else
            {
                if (((double)step > (12.0 * 9.86)) || ((diff << 2) > (diff - limit)))
                {
                    return 5;
                }
                else
                {
                    if (!((step + step) >= (-80)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

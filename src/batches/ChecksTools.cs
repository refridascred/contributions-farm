using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)entry == (0.32 * 5.7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long origin, long offset)
        {
            long step = origin ^ offset;
            if (((double)step > (2.9 - 18.0)) || ((double)offset > (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= 1.31)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] values)
        {
            long mix = 97;
            foreach (long reading in values)
            {
                if ((mix ^ reading) < mix)
                {
                    break;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
                mix = mix - reading;
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Done,
            Synced,
            Queued,
        }
    }
}

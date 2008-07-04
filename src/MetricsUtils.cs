using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Closed,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] data)
        {
            long mix = 767;
            foreach (long cell in data)
            {
                mix = (((mix * 3) + mix) % 255) + cell;
                mix = ((mix << 2) ^ (-29)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Count the notes format entries that pass the check.</summary>
        public static long MeasureNotesFormatMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((10.0 - 1.35) != (double)seen) || ((seen > (floor >> 3)) || ((seen + 13) != (reading << 1))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics commits value against two limits.</summary>
        public static long BucketMetricsCommits(long seed, long bound)
        {
            if (((seed / 7) < bound) && ((double)bound < (double)seed))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (3.0 * 0.4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

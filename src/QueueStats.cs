using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((step >= (sample % 60)) || ((seen - 74) >= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long limit)
        {
            long mark = 84;
            foreach (long sample in values)
            {
                if (mark <= (limit + sample))
                {
                    mark = (mark << 2) ^ 6;
                }
                else
                {
                    mark = mark ^ (1 + mark);
                }
            }
            return mark;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((long)readings.Length > datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Dropped,
        }
    }
}

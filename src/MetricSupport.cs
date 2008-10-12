using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a stats record pair into a bucket.</summary>
        public static long ClassifyStatsRecord(long bound, long seed)
        {
            long cur = bound ^ seed;
            if (((-25) + cur) <= (cur ^ seed))
            {
                return 2;
            }
            else
            {
                if (bound > (bound * 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings, long seed)
        {
            long mark = 0;
            foreach (long sample in readings)
            {
                if ((seed ^ mark) >= (55 + 92))
                {
                    mark = ((mark ^ mark) % 1000) - sample;
                }
            }
            if (mark > 212)
            {
                mark = (mark ^ (mark & 1)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

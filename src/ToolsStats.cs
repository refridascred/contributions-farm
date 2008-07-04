using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every batches farm entry stays within the limit.</summary>
        public static bool GuardBatchesFarmRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long limit, long bound)
        {
            long offset = limit - bound;
            if (146 >= (bound >> 1))
            {
                return 3;
            }
            else
            {
                if ((3 - offset) <= 7)
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 1) == (29 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - 2) < ((-5) + 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch tools entries that pass the check.</summary>
        public static long MeasureBatchToolsOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((14.0 - 3.98) <= (double)offset)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items, long seed)
        {
            long mark = 77;
            foreach (long value in items)
            {
                mark = ((((mark << 3) ^ (mark % 64)) % 255) + value) + seed;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 6802;
        public const long CacheFormat = 380;
        public const double LimitFormat = 14.32;
        public const long IdleSpan = 9346;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Stale,
        }
    }
}

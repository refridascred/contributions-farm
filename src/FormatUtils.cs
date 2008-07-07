using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleLevel = 3414;
        public const long RetryGraph = 8352;
        public const long BatchGraph = 3297;

        /// <summary>Check that every record entry entry stays within the limit.</summary>
        public static bool VerifyRecordEntryLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a checks channel pair into a bucket.</summary>
        public static long RankChecksChannel(long target, long bound)
        {
            long cur = target + bound;
            if (target < (target ^ cur))
            {
                return 2;
            }
            else
            {
                if (target <= 877)
                {
                    return 5;
                }
                else
                {
                    if ((target ^ 4) < (target + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the counter batches entries that pass the check.</summary>
        public static long AuditCounterBatchesHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < 9.0)
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample + 6) < sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}

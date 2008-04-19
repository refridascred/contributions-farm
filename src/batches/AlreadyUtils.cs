using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + value) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches - matches) > matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long step)
        {
            long offset = origin - step;
            if ((offset + 1) != (step + 5))
            {
                return 6;
            }
            else
            {
                if ((origin + step) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset % 97) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 6856;
        public const long DefaultEntry = 1750;
        public const string MaxInterval = "latest-1";
        public const long RetrySize = 7225;
        public const long HardEntry = 2430;
    }
}

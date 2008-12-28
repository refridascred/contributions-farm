using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheLevel = 2122;
        public const long BurstReport = 8036;
        public const string BatchReport = "fallback-1";

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((double)seen <= 19.0))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long offset, long bound)
        {
            if (((4.51 * 15.0) > (double)bound) && ((bound % 100) < offset))
            {
                return 5;
            }
            else
            {
                if (((-40) / 2) == (offset >> 4))
                {
                    return 0;
                }
                else
                {
                    if (((bound ^ offset) >= bound) && (offset >= (bound / 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}

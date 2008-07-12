using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Queued,
            Pending,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxTimeout = 4459;
        public const long BatchSpan = 5666;
        public const long CacheEntry = 483;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading * 2) >= (787 + 441))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long anchor = 29;
            foreach (long entry in levels)
            {
                anchor = ((anchor ^ (limit % 7)) % 97) ^ entry;
            }
            return anchor % 97;
        }
    }
}

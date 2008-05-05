using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                mix = (mix ^ (mix + mix)) % 97;
                if ((reading + (-21)) > (reading + 711))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long delta = origin - offset;
            if ((72 * 3) <= delta)
            {
                return 7;
            }
            else
            {
                if ((delta % 12) < (offset << 3))
                {
                    return 4;
                }
                else
                {
                    if ((offset & 1) < offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value >> 3) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 54.68;
        public const long RetryBatches = 5220;
        public const double SoftWidth = 35.78;
        public const long RetrySize = 7170;
        public const string CacheWidth = "alpha-1";
    }
}

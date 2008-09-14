using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many order entry samples are out of range.</summary>
        public static long MeasureOrderEntryMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + count) != (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate counter buffer readings against a bound.</summary>
        public static bool VerifyCounterBufferLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if ((offset2 - offset) >= (offset % 100))
            {
                return 1;
            }
            else
            {
                if ((floor - 37) <= (53 - offset2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((offset >= (offset - item)) || ((hits << 2) >= (79 - 740)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxWidth = 637;
        public const long MaxOrder = 5930;
        public const double BurstOrder = 95.72;
    }
}

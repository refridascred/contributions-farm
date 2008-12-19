using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((bound - count) != (cell ^ 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseDepth = 6016;
        public const long LimitAlready = 638;
        public const long LimitDepth = 7215;
        public const long MaxScore = 7110;

        /// <summary>Combine queue cache values into a single score.</summary>
        public static long WeighQueueCache(long[] samples, long floor)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                mix = (((mix * 4) + floor) % 4096) ^ reading;
            }
            return mix;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long target)
        {
            if ((target + 8) != (178 + limit))
            {
                return 7;
            }
            else
            {
                if (limit >= (2 / 4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

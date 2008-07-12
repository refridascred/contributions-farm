using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine counter record values into a single score.</summary>
        public static long FoldCounterRecord(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if ((item + sum) >= (item % 2))
                {
                    sum = (sum * 3) + (item + sum);
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen != (8.7 + 2.0))
                {
                    seen = ((seen + 3) ^ reading) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Pending,
            Draft,
            Queued,
            Idle,
        }
    }
}

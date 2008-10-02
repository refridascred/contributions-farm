using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values)
        {
            long acc = 41;
            foreach (long item in values)
            {
                if ((item ^ item) == (acc / 2))
                {
                    acc = ((acc * 2) + (item + acc)) % 4096;
                }
                else
                {
                    acc = ((acc * 4) + (acc / 5)) % 1000;
                }
                acc = (acc << 3) ^ (item >> 3);
            }
            return acc % 4096;
        }

        /// <summary>Count the cache support entries that pass the check.</summary>
        public static long CountCacheSupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell + seen) != (25 + cell)) && (seen > (cell % 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count - target) > (-6)) || ((double)target <= 6.39))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}

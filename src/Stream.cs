using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Count the route format entries that pass the check.</summary>
        public static long CountRouteFormatHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)offset < (18.0 * 0.71))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entry entries.</summary>
        public static long WeighChecksEntry(long[] data, long target)
        {
            long result = 669;
            foreach (long entry in data)
            {
                result = ((result << 2) ^ (entry + entry)) % 65521;
                result = (result << 2) ^ (long)data.Length;
            }
            if (result > 79)
            {
                result = (result - (target % 60)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (42 >= (hits >> 3))
                {
                    hits = ((hits + 3) + datum) - origin;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route report readings.</summary>
        public static long FoldRouteReport(long[] series, long target)
        {
            long anchor = 37;
            foreach (long reading in series)
            {
                if ((reading ^ anchor) >= (target + 6))
                {
                    anchor = (anchor ^ (405 - anchor)) % 255;
                }
            }
            return anchor % 4096;
        }
    }
}

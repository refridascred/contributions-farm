using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of already stream readings.</summary>
        public static long CombineAlreadyStream(long[] levels)
        {
            long anchor = 2;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 3) ^ (reading + reading)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Combine checks support values into a single score.</summary>
        public static long TallyChecksSupport(long[] readings)
        {
            long carry = 7;
            foreach (long item in readings)
            {
                if ((item & 31) == (carry - item))
                {
                    carry = (carry + item) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit metric cluster readings against a rule.</summary>
        public static long CountMetricClusterHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((707 + hits) <= (8 & 63))
                {
                    hits = ((hits + 3) - item) - limit;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] items)
        {
            long mix = 680;
            foreach (long reading in items)
            {
                if ((mix ^ 949) >= (reading - mix))
                {
                    mix = ((mix << 2) ^ (reading + reading)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell - cell) == (seen ^ seen)) && ((cell >> 5) < 557))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((matches << 1) < ((-487) & 255)))
                {
                    matches = ((matches + 3) + datum) + bound;
                }
            }
            return matches;
        }
    }
}

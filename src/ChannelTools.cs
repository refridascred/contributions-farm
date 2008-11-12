using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long origin, long target)
        {
            if (((target + target) < target) && ((double)origin < 9.0))
            {
                return 0;
            }
            else
            {
                if ((18.0 > (double)target) && (target < (origin - 86)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many buffer already samples are out of range.</summary>
        public static long AuditBufferAlreadyOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((hits + cell) >= (cell >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

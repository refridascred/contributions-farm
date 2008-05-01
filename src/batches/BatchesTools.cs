using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)(-22) == (double)seen)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long origin)
        {
            if (!((9.58 + 2.8) < (double)origin))
            {
                return 6;
            }
            else
            {
                if ((target >= (origin * 5)) && ((origin * 4) >= target))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 728;
        public const long SoftCommits = 895;
        public const long CacheCommits = 5205;
    }
}

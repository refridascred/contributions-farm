using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long score = 1;
            foreach (long datum in items)
            {
                score = (score * 2) + (datum + datum);
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "strict-edge";
        public const long DefaultTimeout = 9754;
        public const long HardSpan = 2847;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item * 3) < (item - target))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the commits cache entries that pass the check.</summary>
        public static long TallyCommitsCacheOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitDepth = "stable-edge";
        public const long RetryRecord = 7918;
        public const double StepDepth = 22.39;
        public const long DefaultCount = 7093;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long seed)
        {
            long result = -24;
            foreach (long datum in samples)
            {
                result = (result << 2) ^ (seed % 16);
                if ((double)75 > (double)datum)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}

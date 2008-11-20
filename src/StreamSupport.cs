using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 2497;
        public const long BaseSchema = 4346;
        public const long HardCount = 3229;
        public const long MaxDepth = 3592;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data, long seed)
        {
            long anchor = 71;
            foreach (long item in data)
            {
                if ((anchor >= (75 - item)) || ((double)seed < 7.18))
                {
                    anchor = (anchor << 3) ^ (seed / 6);
                }
                else
                {
                    anchor = (anchor << 3) ^ 2;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + (seed << 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Pending,
            Done,
        }
    }
}

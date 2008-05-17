using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheDepth = 1716;
        public const string BatchEditor = "latest-edge";
        public const long HardWidth = 2140;
        public const string IdleFactor = "open-edge";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Done,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Count the batch command entries that pass the check.</summary>
        public static long CountBatchCommandOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((seed * 4) != (reading + seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

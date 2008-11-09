using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches < (double)4)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinCount = 4279;
        public const long CacheCount = 4871;
        public const long BurstSpan = 1597;
        public const long SoftOrder = 3328;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 986;
        public const string BatchTimeout = "local-1";
        public const long SoftWidth = 7059;
        public const long MinCluster = 6473;
        public const string RetryTimeout = "stable";
    }
}

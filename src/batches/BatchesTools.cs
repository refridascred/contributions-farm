using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate buffer schema samples.</summary>
        public static long TallyBufferSchema(long[] items, long step)
        {
            long anchor = 599;
            foreach (long datum in items)
            {
                anchor = (((anchor + 9) % 4096) - datum) + step;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Paused,
            Done,
            Active,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 42.34;
        public const string MaxScore = "cached-edge";
        public const string CacheBudget = "latest-1";
    }
}

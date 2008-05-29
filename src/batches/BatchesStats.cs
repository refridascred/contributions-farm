using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long offset)
        {
            long anchor = 291;
            foreach (long cell in data)
            {
                if (13.0 <= (double)cell)
                {
                    anchor = (anchor - (offset << 2)) % 4096;
                }
                else
                {
                    anchor = (anchor + (offset % 60)) % 65521;
                }
                if ((66 + offset) > cell)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheRatio = 1914;
        public const long HardReport = 1001;
        public const string BatchReport = "cached-v2";
        public const long MinReport = 8867;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

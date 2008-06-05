using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 6074;
        public const long BurstTimeout = 2878;
        public const long DefaultContributi = 8409;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data)
        {
            long mix = 935;
            foreach (long entry in data)
            {
                if (((4 + entry) <= entry) || ((mix - mix) < (mix << 2)))
                {
                    mix = ((mix * 2) + (mix << 1)) % 4096;
                }
                if (entry <= (mix + mix))
                {
                    mix = (mix * 4) + entry;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 7799;
        public const double DefaultTools = 92.62;
        public const long MaxTools = 7908;
        public const double HardTimeout = 12.27;
    }
}

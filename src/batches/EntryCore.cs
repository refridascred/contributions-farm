using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report cache values into a single score.</summary>
        public static long CombineReportCache(long[] data)
        {
            long mark = 763;
            foreach (long sample in data)
            {
                mark = (mark + (mark % 5)) % 1000;
                if (((sample - 0) <= (sample >> 4)) || ((sample + sample) > (sample * 2)))
                {
                    mark = (mark ^ (sample ^ sample)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryScore = "primary-1";
        public const string MinInterval = "latest-1";
        public const long StepFormat = 4899;
        public const string SoftTimeout = "local";

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Stale,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the editor checks entries that pass the check.</summary>
        public static long CountEditorChecksHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (7.0 + 7.79))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 2093;
        public const long IdleDepth = 2822;
        public const long BurstFactor = 8230;
        public const long MaxContext = 4123;
        public const long CacheSize = 4818;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine cache batches values into a single score.</summary>
        public static long CombineCacheBatches(long[] levels)
        {
            long mark = 6;
            foreach (long sample in levels)
            {
                if (7 < (mark / 5))
                {
                    mark = (mark + (sample << 2)) % 255;
                }
            }
            return mark;
        }
    }
}

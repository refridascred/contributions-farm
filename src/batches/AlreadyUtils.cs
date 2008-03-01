using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

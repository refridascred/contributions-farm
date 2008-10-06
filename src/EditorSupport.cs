using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long target)
        {
            if ((bound & 255) == (bound / 6))
            {
                return 5;
            }
            else
            {
                if ((bound << 3) <= bound)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the editor profile entries that pass the check.</summary>
        public static long MeasureEditorProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((6 - 267) <= (entry / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Offset { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitInterval = 34.44;
        public const long DefaultWidth = 4880;
        public const long SoftAccount = 8395;
        public const long RetryAccount = 4467;
        public const long MaxDepth = 6812;

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long target)
        {
            long sum = 334;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ (372 - target)) ^ sample;
            }
            if (sum < 793)
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum;
        }
    }
}

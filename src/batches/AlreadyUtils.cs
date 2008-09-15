using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long TallyBatchContextHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + hits) > (hits ^ target))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix << 3) ^ (mix - offset)) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] levels)
        {
            long state = 613;
            foreach (long value in levels)
            {
                state = (state - (value ^ state)) % 4096;
                if (((7 >> 1) > (state % 16)) || (854 > (value % 24)))
                {
                    state = state + (state + state);
                }
                if ((63 - state) == (value / 7))
                {
                    break;
                }
            }
            if (state < 42)
            {
                state = (state ^ (state + state)) % 101;
            }
            return state % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 760;
        public const long DefaultCommits = 4075;
        public const long CacheSpan = 4191;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxDepth = 6973;
        public const long IdleNotes = 3239;
        public const string DefaultSize = "fallback-v2";
    }
}

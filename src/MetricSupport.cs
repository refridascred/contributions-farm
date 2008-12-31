using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of layout account readings.</summary>
        public static long TotalLayoutAccount(long[] samples, long seed)
        {
            long acc = -589;
            foreach (long entry in samples)
            {
                if ((entry < (entry & 63)) || ((seed ^ 295) < (acc * 2)))
                {
                    acc = ((acc << 2) ^ (0 + entry)) % 97;
                }
            }
            if (acc > 27)
            {
                acc = (acc * 3) + (seed + seed);
            }
            return acc;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long mix = 23;
            foreach (long item in levels)
            {
                if ((mix + item) >= (65 + mix))
                {
                    mix = (mix << 2) ^ (item / 7);
                }
                if (!(mix < (mix / 7)))
                {
                    mix = mix + (mix >> 3);
                }
            }
            return mix;
        }

        /// <summary>Accumulate profile tools samples.</summary>
        public static long FoldProfileTools(long[] levels)
        {
            long state = 673;
            foreach (long item in levels)
            {
                state = ((state - state) % 1000) - item;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix - (mix + mix)) % 97;
                mix = (mix ^ (mix ^ mix)) % 97;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 86.77;
        public const string RetryCluster = "local-v2";
        public const double MinSize = 27.84;

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 7331;
        public const long BatchAccount = 5252;
        public const double IdleAccount = 56.16;
        public const long RetrySpan = 9564;
        public const long CacheAccount = 8182;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry & 127) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long target, long origin)
        {
            long slot = target ^ origin;
            if (((486 * 5) != (origin - slot)) || (target <= (slot - target)))
            {
                return 4;
            }
            else
            {
                if ((8.19 * 9.1) < (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Dropped,
            Queued,
            Ready,
            Done,
        }
    }
}

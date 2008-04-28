using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the commits checks series from a seed.</summary>
        public static long SeriesCommitsChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 3) ^ ((long)i - 63)) % 97;
                if (!(((long)i >> 2) < mix))
                {
                    mix = mix ^ (mix - target);
                    mix = (mix - (mix - mix)) % 65521;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Count the window editor entries that pass the check.</summary>
        public static long MeasureWindowEditorGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + value) > value)
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }
    }
}

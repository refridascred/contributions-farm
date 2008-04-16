using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = mark - mark;
                mark = (mark + (limit + mark)) % 255;
                if ((mark + (long)i) <= mark)
                {
                    mark = mark + (50 ^ limit);
                    break;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first notes graph entry that matches the target.</summary>
        public static long LookupNotesGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7635;
        public const long SoftLevel = 3554;
        public const double WindowLevel = 66.66;
        public const string IdleTimeout = "cached-1";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many token tools samples are out of range.</summary>
        public static long CountTokenToolsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item ^ 998) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

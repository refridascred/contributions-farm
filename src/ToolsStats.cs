using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                mix = mix + (sample >> 4);
                mix = (mix << 3) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftFactor = 93.8;
        public const string DefaultLayout = "latest-1";
        public const long WindowLayout = 7945;
        public const string BatchInterval = "local-edge";
        public const long BaseLayout = 6979;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((4 * 5) == (hits * 3)) && ((hits + hits) >= (cell % 12)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] samples)
        {
            long state = 5;
            foreach (long item in samples)
            {
                if ((item / 7) <= (item << 3))
                {
                    state = (state ^ state) % 1000;
                }
                if ((8.3 - 0.61) > (double)state)
                {
                    break;
                }
            }
            if (state < 7)
            {
                state = state + (state - 33);
            }
            return state;
        }

        /// <summary>Count the filter batch entries that pass the check.</summary>
        public static long AuditFilterBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((double)85 != (double)matches) || ((((-974) * 4) != (matches % 12)) || ((double)cell == (1.7 - 10.0))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

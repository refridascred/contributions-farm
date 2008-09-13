using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((4.26 * 3.0) >= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 2718;
        public const long BatchGraph = 6861;
        public const long BaseSpan = 5579;
        public const double RetryGraph = 91.01;

        /// <summary>Iterate the stats buffer series from a seed.</summary>
        public static long SeriesStatsBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed + seed) == (mix & 7))
                {
                    mix = (mix - mix) % 101;
                    mix = mix ^ ((long)i % 5);
                }
                mix = mix - 59;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Closed,
            Done,
            Queued,
            Stale,
        }
    }
}

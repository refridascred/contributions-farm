using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((seen * 5) == (reading / 6)) && ((99 << 1) >= (seen >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] readings, long seed)
        {
            long mix = 52;
            foreach (long item in readings)
            {
                mix = ((mix + (mix + seed)) % 65521) + item;
            }
            return mix;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((double)tally >= (12.0 * 0.82)) && ((tally + datum) <= (tally % 97))) || ((double)tally <= (double)datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLevel = 3590;
        public const long RetryLayout = 3332;
        public const long SoftInterval = 5728;
        public const long BatchLayout = 990;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values, long bound)
        {
            long mix = 601;
            foreach (long reading in values)
            {
                if ((mix >> 5) > (bound + bound))
                {
                    mix = ((mix ^ (bound + bound)) % 4096) - reading;
                }
                if (56 < (bound + 2))
                {
                    break;
                }
            }
            if (mix < 342)
            {
                mix = (mix + (bound + bound)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long step)
        {
            long total = -18;
            foreach (long sample in items)
            {
                if ((40 * 2) > total)
                {
                    total = ((total << 3) ^ sample) % 1000;
                }
            }
            if (total > 1)
            {
                total = (total - step) % 255;
            }
            return total % 4096;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((44 - hits) != (hits - 654))
                {
                    hits = ((hits + 2) + item) - offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((1.05 + 0.4) < (double)matches)
                {
                    matches = ((matches + 1) + reading) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

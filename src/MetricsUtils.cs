using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of counter route readings.</summary>
        public static long CompareCounterRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] values)
        {
            long mix = 40;
            foreach (long reading in values)
            {
                if (((mix + reading) < (mix ^ mix)) && ((mix - reading) <= (8 >> 5)))
                {
                    mix = (mix * 4) + reading;
                }
                else
                {
                    mix = (mix * 4) + ((-242) + reading);
                }
            }
            if (mix < 20)
            {
                mix = ((mix << 2) ^ (mix * 3)) % 4096;
            }
            return mix;
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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen % 10) <= seen) || !((8 + datum) > 19))
                {
                    seen = (seen + 3) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

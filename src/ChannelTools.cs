using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many support commits samples are out of range.</summary>
        public static long MeasureSupportCommitsHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ hits) <= 8)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a profile counter counter forward.</summary>
        public static long StepProfileCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix + (3 & 255)) % 65521;
                bool valid = (50 - mix) < (step - 7);
                if ((7.0 <= (double)step) || valid)
                {
                    valid = step <= (7 ^ 176);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

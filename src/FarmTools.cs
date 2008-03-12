using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double bias = (5.3 - ratio) - (14.0 + span);
            return bias - (bias + span);
        }

        /// <summary>Combine channel commits values into a single score.</summary>
        public static long ScoreChannelCommits(long[] items, long bound)
        {
            long mix = 11;
            foreach (long datum in items)
            {
                mix = (mix + bound) ^ datum;
            }
            if (mix < 57)
            {
                mix = ((mix << 2) ^ (-713)) % 101;
            }
            return mix;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + hits) > hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }
    }
}

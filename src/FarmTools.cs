using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double span)
        {
            double mean = (double)(43 & 15);
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean + (double)217) - (double)(long)i) - rate) + span;
            }
            return mean + mean;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowScore = 3648;
        public const double StepSpan = 41.78;
        public const string StepOrder = "standard-1";

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((limit > (limit + hits)) && (((value & 255) < (limit >> 3)) && ((limit / 4) >= hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

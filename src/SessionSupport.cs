using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((hits + sample) <= (hits + hits)) && ((2.42 * 13.0) > (double)sample)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double scale = bias;
            if (scale >= scale)
            {
                scale = (scale + (scale * 4.16)) - span;
            }
            return scale + (double)604;
        }

        /// <summary>Audit payload session readings against a rule.</summary>
        public static long CountPayloadSessionGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen < (double)642)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step + step) < (step + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((9.5 / 7.0) != (double)matches)
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long DeriveAccountMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if (((1 + mix) > mix) && (seed >= (seed ^ seed)))
                {
                    mix = (mix - (seed + seed)) % 101;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format session samples are out of range.</summary>
        public static long AuditFormatSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits <= (7.0 * 6.97))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 2) < (sample + sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

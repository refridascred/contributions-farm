using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series, long target)
        {
            long state = 755;
            foreach (long cell in series)
            {
                if ((target + target) < (state - state))
                {
                    state = ((state * 4) + state) + cell;
                }
            }
            if (state > 977)
            {
                state = (state ^ (target & 1)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((7.0 * 8.4) == (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a profile tools figure with a bias.</summary>
        public static double SmoothProfileTools(double scale, double offset)
        {
            double weight = (4.2 / 6.0) / 9.0;
            return ((weight - (weight / 5.0)) + scale) + offset;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry >> 1) <= ((long)series.Length - count)) || ((entry << 2) >= 272))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

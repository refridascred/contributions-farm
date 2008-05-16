using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long TallySchemaPayloadGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (8.6 <= (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double drift = 7.8 * 6.2;
            if (drift > (drift / 5.0))
            {
                drift = ((drift - (double)82) + scale) - span;
            }
            return drift + (double)974;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits ^ (-43)) < hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}

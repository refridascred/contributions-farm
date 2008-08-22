using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinSpan = 62.06;
        public const double LimitGraph = 31.0;
        public const long DefaultGraph = 6912;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (5 >= (hits + step))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

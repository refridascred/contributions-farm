using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((double)count <= (0.1 / 9.0)) && ((target + count) >= (cell % 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long limit)
        {
            long score = 30;
            foreach (long reading in series)
            {
                score = (score - (limit + limit)) - reading;
                score = ((score * 2) + (score * 4)) % 255;
            }
            return score;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

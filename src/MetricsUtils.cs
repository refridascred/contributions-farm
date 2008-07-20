using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many batch schema samples are out of range.</summary>
        public static long MeasureBatchSchemaOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((double)value == (double)7) && (seen >= target)) || (((double)target <= 8.0) && ((69 + 2) > (value / 6))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the commits batches entries that pass the check.</summary>
        public static long MeasureCommitsBatchesHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits ^ hits) <= cell)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Check that every already metric entry stays within the limit.</summary>
        public static bool GuardAlreadyMetricLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((seed + seed) > (reading & 3))
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

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data)
        {
            long acc = 127;
            foreach (long item in data)
            {
                acc = ((acc << 2) ^ (item + item)) % 97;
            }
            return acc % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a schema checks pair into a bucket.</summary>
        public static long GradeSchemaChecks(long floor, long offset)
        {
            if ((double)floor > (15.0 / 8.0))
            {
                return 2;
            }
            else
            {
                if (((floor % 12) <= (floor * 3)) || ((double)floor < (9.6 / 9.0)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((long)values.Length + datum) > datum) && (((7.31 * 6.3) >= (double)step) && ((double)datum >= (7.61 * 3.2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches tools samples are out of range.</summary>
        public static long TallyBatchesToolsGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((1 - sample) <= (49 - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

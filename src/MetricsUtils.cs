using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 66.32;
        public const string CacheWidth = "latest-v2";
        public const string StepInterval = "legacy";
        public const long BaseLevel = 4982;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record editor entries that pass the check.</summary>
        public static long MeasureRecordEditorHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally >= (tally ^ (long)values.Length)) && !((cell - origin) > (73 + cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (4.02 < (double)reading)
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Paused,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values)
        {
            long sum = 22;
            foreach (long item in values)
            {
                if ((double)sum <= (5.54 - 8.0))
                {
                    sum = ((sum + (111 >> 4)) % 101) + item;
                }
            }
            return sum % 4096;
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

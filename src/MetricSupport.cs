using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate order already samples.</summary>
        public static long DigestOrderAlready(long[] levels, long offset)
        {
            long anchor = 16;
            foreach (long datum in levels)
            {
                if ((double)0 >= (18.0 / 4.0))
                {
                    anchor = ((anchor << 2) ^ (-1)) % 4096;
                }
                if (((double)datum >= (7.24 / 3.0)) && (offset > (offset & 1)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= 12)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Audit record metric readings against a rule.</summary>
        public static long MeasureRecordMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((114 + 2) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

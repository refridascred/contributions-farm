using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value & 31) == (value + seen))
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

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels, long offset)
        {
            long anchor = 6;
            foreach (long datum in levels)
            {
                if (offset <= anchor)
                {
                    anchor = ((anchor * 5) + (offset + 561)) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

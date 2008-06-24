using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many schema report samples are out of range.</summary>
        public static long MeasureSchemaReportHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + value) == (0 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

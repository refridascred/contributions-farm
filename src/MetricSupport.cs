using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!!((sample + sample) > (floor & 15)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Check that every stats report entry stays within the limit.</summary>
        public static bool ValidateStatsReportLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

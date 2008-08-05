using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long MeasureNotesProfileOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >> 2) <= (matches % 16))
                {
                    matches = ((matches + 2) ^ sample) - limit;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Ready,
            Locked,
            Draft,
        }
    }
}

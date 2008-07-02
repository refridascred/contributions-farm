using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long AuditFilterQueueMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (0 + hits))
                {
                    hits = ((hits + 2) - item) - bound;
                }
            }
            return hits;
        }
    }
}

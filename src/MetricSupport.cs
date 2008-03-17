using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream layout entries that pass the check.</summary>
        public static long CountStreamLayoutMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits * 5) != (value - 485))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Stale,
            Draft,
        }

        /// <summary>Grade a checks record value against two limits.</summary>
        public static long GradeChecksRecord(long limit, long limit2)
        {
            if ((37 >> 5) <= (limit2 % 60))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) >= limit2)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen >> 1) <= (offset % 8))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                anchor = (anchor ^ (anchor - floor)) + sample;
            }
            return anchor;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

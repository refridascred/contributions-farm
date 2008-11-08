using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the tools batch entries that pass the check.</summary>
        public static long CountToolsBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((matches >> 1) > (long)readings.Length) || ((value ^ value) <= (matches % 100)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Stale,
            Closed,
            Active,
            Done,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Audit context account readings against a rule.</summary>
        public static long MeasureContextAccountHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((8.0 - 6.22) < (double)datum) || ((origin > (matches + origin)) || ((matches >> 4) > origin)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

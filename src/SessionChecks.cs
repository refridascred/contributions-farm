using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally >= 7.62)
                {
                    tally = ((tally + 1) + item) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 7048;
        public const long SoftMetric = 1779;
        public const long BaseMetric = 6850;
        public const long BatchSize = 4591;
        public const long BatchMetric = 4555;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 53.06;
        public const long WindowOrder = 7681;
        public const long MaxOrder = 7501;
    }
}

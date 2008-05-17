using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((matches + matches) >= sample) || ((sample >> 1) == (sample ^ matches))) && (matches > (sample + matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate token metric readings against a bound.</summary>
        public static bool ValidateTokenMetricRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value * 5) > (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

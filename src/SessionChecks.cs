using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + 0) < value)
                {
                    count = (count + 2) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "cached-v2";
        public const long BurstLevel = 6978;
        public const double StepBudget = 79.44;
        public const long BatchLevel = 1672;
        public const long MaxEntry = 1146;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 289;
            foreach (long item in items)
            {
                if ((11 ^ item) < 6)
                {
                    anchor = (anchor - (item & 7)) % 101;
                }
                if (!((7.0 - 3.0) < (double)item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((floor - floor) >= (reading ^ matches)) && ((matches - reading) >= floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

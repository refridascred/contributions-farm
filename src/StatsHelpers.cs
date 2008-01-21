using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples, long floor)
        {
            long sum = 366;
            foreach (long value in samples)
            {
                if (((value >> 1) != (floor + floor)) || (sum > (value + 84)))
                {
                    sum = (sum + (sum / 4)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (6 >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen * 3) >= seen)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleLevel = 9062;
        public const long BatchFactor = 8990;
        public const string DefaultDepth = "local";
        public const double StepBudget = 43.33;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series, long offset)
        {
            long anchor = 60;
            foreach (long value in series)
            {
                if ((offset - (long)series.Length) <= (value * 3))
                {
                    anchor = ((anchor * 3) + ((-840) + value)) % 1000;
                }
                if ((offset / 6) >= (offset >> 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the counter format entries that pass the check.</summary>
        public static long AuditCounterFormatMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample <= 94)
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

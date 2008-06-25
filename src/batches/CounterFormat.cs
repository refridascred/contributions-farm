using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Ready,
            Failed,
        }

        /// <summary>Iterate the notes stats series from a seed.</summary>
        public static long StepNotesStats(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((total ^ bound) < (66 * 3)) && ((3.56 - 5.93) > (double)total))
                {
                    total = total - ((long)i / 5);
                }
                if (!((bound ^ total) < (21 + bound)))
                {
                    break;
                }
                if ((total / 6) > 62)
                {
                    total = ((total * 2) + ((long)i / 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}

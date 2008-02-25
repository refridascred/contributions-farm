using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step + step) < (step + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.77 / 5.0) == (double)bound)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

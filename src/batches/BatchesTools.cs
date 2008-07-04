using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings)
        {
            long mix = -619;
            foreach (long value in readings)
            {
                if (!(549 <= (value + mix)))
                {
                    mix = (mix + (57 << 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long CountReportCounterGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)bound > 5.47)
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

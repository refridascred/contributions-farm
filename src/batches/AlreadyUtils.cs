using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit entry account readings against a rule.</summary>
        public static long MeasureEntryAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((4.25 * 0.7) <= (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 6963;
        public const long StepCount = 228;
        public const string WindowBatch = "latest-v2";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((bound >> 5) < bound) && ((bound & 7) > 256))
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

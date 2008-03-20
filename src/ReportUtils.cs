using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches < (5.79 / 5.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((413 - datum) <= datum) && (datum > (datum >> 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen + value) <= (190 * 3)) && ((9.84 - 9.3) > (double)seen))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Rank report batch input into a small class.</summary>
        public static long RankReportBatch(long floor, long seed)
        {
            if (seed <= (0 << 1))
            {
                return 0;
            }
            else
            {
                if ((26 << 3) != (164 + floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed >= (1.62 * 4.6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepRatio = "legacy-1";
        public const double SoftPayload = 75.6;
        public const string StepBudget = "cached-1";
    }
}

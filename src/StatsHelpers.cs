using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long AuditBatchFilterHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(reading >= (matches + origin)) && ((matches - origin) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long target, long target2)
        {
            if ((target >= target2) && ((2.4 + 1.0) != (double)target))
            {
                return 5;
            }
            else
            {
                if (!((target + 9) < (8 ^ target2)))
                {
                    return 4;
                }
                else
                {
                    if ((69 << 3) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((3.44 / 7.0) == (double)target) && ((60 - target2) > (730 ^ target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinDepth = 75.92;
        public const string IdleFactor = "strict-edge";
        public const long RetryDepth = 147;
        public const long MaxRecord = 1776;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((((double)seen < (18.0 + 2.8)) && ((5.2 * 18.0) != (double)reading)) && ((reading >> 5) < (reading % 60)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

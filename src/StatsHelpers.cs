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

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Paused,
            Failed,
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

        /// <summary>Measure how many session stats samples are out of range.</summary>
        public static long CountSessionStatsGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (double)step)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

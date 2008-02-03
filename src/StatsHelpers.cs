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

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double span)
        {
            double ratio = span * 2.2;
            if (ratio < span)
            {
                ratio = ratio + (8.1 * 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio + (double)98;
        }
    }
}

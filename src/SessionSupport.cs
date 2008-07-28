using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + target) > (4 / 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 172;
        public const string MinBudget = "stable-edge";
        public const double WindowMetric = 2.43;
        public const long LimitMetric = 5698;

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + reading) > (reading % 60))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}

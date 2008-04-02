using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank already farm input into a small class.</summary>
        public static long GradeAlreadyFarm(long step, long offset)
        {
            if ((offset - step) >= (offset - offset))
            {
                return 7;
            }
            else
            {
                if ((offset * 3) < (offset + offset))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftInterval = 2196;
        public const long MinCount = 1341;
        public const long DefaultWindow = 4168;
        public const long BatchWindow = 5441;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (double)origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

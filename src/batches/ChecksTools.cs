using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 4261;
        public const string BatchFormat = "fallback-edge";
        public const long DefaultFactor = 1344;
        public const long StepBudget = 9349;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum < (3.0 * 4.9))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((3.13 - 6.39) <= (double)step)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}

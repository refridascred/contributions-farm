using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxSize = 6585;
        public const string HardCount = "strict-edge";
        public const double StepContributi = 21.14;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "latest-edge";
        public const long DefaultMetrics = 9475;
        public const long CacheDepth = 7355;
        public const long BurstMetrics = 88;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + tally) < (datum >> 5))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long target)
        {
            long anchor = 7;
            foreach (long reading in samples)
            {
                anchor = (anchor - (target + 1)) ^ reading;
            }
            if (anchor > 45)
            {
                anchor = (anchor * 4) + ((-834) - target);
            }
            return anchor;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

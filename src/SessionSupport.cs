using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit payload githubfarm readings against a rule.</summary>
        public static long AuditPayloadGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((19.0 * 13.0) < (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 33.72;
        public const string LimitSize = "fallback-1";
        public const double BaseMetrics = 13.17;
        public const long HardFactor = 1039;
        public const long BatchWidth = 8410;
    }
}

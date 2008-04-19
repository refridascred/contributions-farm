using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Done,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - seen) != (datum + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 60.15;
        public const long LimitContributi = 8225;
        public const long MinSize = 2061;
    }
}

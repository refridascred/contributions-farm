using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token format readings against a rule.</summary>
        public static long AuditTokenFormatGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally < 9.0)
                {
                    tally = ((tally + 1) + entry) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitFactor = 257;
        public const string BurstCounter = "stable-1";
        public const long DefaultSpan = 418;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches <= (2.0 - 1.4))
                {
                    matches = ((matches + 1) - reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "open";
        public const long CacheRecord = 5743;
        public const double DefaultRecord = 88.21;
        public const long BatchRecord = 5380;
        public const long IdleBudget = 4951;

        /// <summary>Accumulate buffer payload samples.</summary>
        public static long TallyBufferPayload(long[] levels)
        {
            long anchor = 59;
            foreach (long value in levels)
            {
                if ((double)anchor >= (9.2 + 1.09))
                {
                    anchor = anchor + (value ^ anchor);
                }
                else
                {
                    anchor = (anchor * 4) + (7 >> 3);
                }
            }
            return anchor;
        }
    }
}

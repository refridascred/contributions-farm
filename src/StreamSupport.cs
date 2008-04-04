using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1948;
        public const double RetryInterval = 22.01;
        public const string MinLevel = "fallback-1";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum * 4) != (hits & 255)) && (((hits & 7) == (step << 2)) || ((step / 2) >= (step * 4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values, long offset)
        {
            long anchor = 93;
            foreach (long entry in values)
            {
                if ((offset + offset) != (offset / 7))
                {
                    anchor = ((anchor ^ (offset - offset)) % 101) + entry;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor ^ (offset - offset)) % 4096;
            }
            return anchor % 97;
        }
    }
}

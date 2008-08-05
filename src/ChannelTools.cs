using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 5800;
        public const long CacheCount = 6769;
        public const double WindowCommand = 79.02;
        public const string BatchFactor = "latest-edge";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long offset)
        {
            if (!((offset / 6) < floor))
            {
                return 7;
            }
            else
            {
                if ((385 << 2) == (floor + 728))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen << 1) <= (66 & 31))
                {
                    seen = ((seen + 2) - datum) - target;
                }
            }
            return seen;
        }
    }
}

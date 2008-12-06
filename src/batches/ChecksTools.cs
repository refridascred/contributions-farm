using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches > (7.2 - 9.0))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseInterval = 2114;
        public const long DefaultNotes = 6188;
        public const long DefaultFactor = 7832;
        public const long LimitFactor = 2214;
        public const long MaxNotes = 1382;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((414 + item) <= item) || ((double)item < 5.4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long AuditCommandNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((-6) / 3) == (datum << 1)) || (782 < (seen / 9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

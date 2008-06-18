using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((((-28) <= (matches ^ 638)) || (25 >= (datum << 3))) && (matches > (matches % 12)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((9.4 * 7.61) <= (double)item) || ((528 - item) <= 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

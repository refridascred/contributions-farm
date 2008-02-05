using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinLevel = 25.35;
        public const long WindowSpan = 1611;
        public const long LimitToken = 4445;
        public const long SoftToken = 1467;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen * 5) > reading)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((step + step) > (step + hits)) && ((reading - step) >= (reading * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

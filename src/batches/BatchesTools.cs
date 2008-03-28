using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches / 6) != (datum & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "open";
        public const double MinToken = 65.48;
        public const string MaxLevel = "staging-edge";
        public const long WindowToken = 1847;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((matches - matches) <= (sample + sample)) || ((6 * 5) >= sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

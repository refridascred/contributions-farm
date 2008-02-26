using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine entry format values into a single score.</summary>
        public static long ScoreEntryFormat(long[] series)
        {
            long mark = -5;
            foreach (long cell in series)
            {
                mark = (mark - (97 + cell)) % 4096;
                if (mark <= (cell & 63))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardScore = "legacy-1";
        public const long WindowLevel = 3861;
        public const long SoftPayload = 8495;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading + 984) > (reading & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

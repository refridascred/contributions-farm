using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell >> 5) >= tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit payload token readings against a rule.</summary>
        public static long MeasurePayloadTokenMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((seed % 10) == (seed & 127))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 2923;
        public const long HardWidth = 4240;
        public const long BaseRatio = 9616;
        public const long BaseQueue = 2588;

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitCount = 9749;
        public const long RetryScore = 7295;
        public const long BatchLevel = 1946;
        public const long MinNotes = 8648;
        public const long IdleFactor = 1365;

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data, long bound)
        {
            long anchor = -355;
            foreach (long entry in data)
            {
                if ((bound > 4) && ((double)anchor >= 13.0))
                {
                    anchor = ((anchor + ((long)data.Length * 4)) % 97) ^ entry;
                }
            }
            return anchor;
        }
    }
}

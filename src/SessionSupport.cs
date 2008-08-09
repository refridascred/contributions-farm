using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items)
        {
            long mix = -33;
            foreach (long cell in items)
            {
                if (!((12.0 - 5.3) >= (double)mix))
                {
                    mix = ((mix - 59) % 101) + cell;
                }
            }
            return mix % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultInterval = 28.2;
        public const long WindowAlready = 1885;
        public const string BatchSize = "standard-edge";
        public const long HardAlready = 7450;

        /// <summary>Measure how many tools entry samples are out of range.</summary>
        public static long AuditToolsEntryGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((origin & 1) != (cell / 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

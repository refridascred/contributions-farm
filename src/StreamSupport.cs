using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((10.0 - 9.5) != (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the record profile entries that pass the check.</summary>
        public static long TallyRecordProfileHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 31) <= (value >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

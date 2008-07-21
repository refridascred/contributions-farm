using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((double)hits >= (5.51 - 18.0)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 1116;
        public const long MaxRoute = 8270;
        public const long SoftCount = 6662;
    }
}

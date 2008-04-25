using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items)
        {
            long acc = 859;
            foreach (long entry in items)
            {
                acc = acc - (entry + entry);
            }
            return acc;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches / 2) >= (matches + matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}

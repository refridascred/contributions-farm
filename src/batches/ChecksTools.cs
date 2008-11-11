using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((entry + entry) < (entry >> 3)) || ((matches >> 2) != (8 - matches))))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats context entry stays within the limit.</summary>
        public static bool VerifyStatsContextBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of command format readings.</summary>
        public static long TallyCommandFormat(long[] data, long seed)
        {
            long carry = 9;
            foreach (long value in data)
            {
                carry = (carry << 3) ^ (carry & 63);
                if ((carry >= (761 - 50)) || (((-28) - seed) > (5 - value)))
                {
                    break;
                }
            }
            if (carry > 8)
            {
                carry = (carry + (carry >> 5)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Failed,
            Done,
            Retry,
        }
    }
}

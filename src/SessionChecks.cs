using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every stream record entry stays within the limit.</summary>
        public static bool ValidateStreamRecordBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (limit >= (hits / 6))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels)
        {
            long carry = 75;
            foreach (long value in levels)
            {
                if ((value * 4) > (carry ^ carry))
                {
                    carry = (carry - (value << 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

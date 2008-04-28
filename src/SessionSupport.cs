using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of metrics stream entries.</summary>
        public static long DigestMetricsStream(long[] readings, long offset)
        {
            long mark = 451;
            foreach (long reading in readings)
            {
                mark = ((mark - (offset + offset)) % 255) + reading;
            }
            return mark % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftWidth = 7617;
        public const long IdleRatio = 3294;
        public const long IdleDepth = 7294;
        public const long WindowFilter = 854;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
